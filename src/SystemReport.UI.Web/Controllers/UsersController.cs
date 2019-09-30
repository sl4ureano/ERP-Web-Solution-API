using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SystemReport.ApplicationCore.Entity;
using SystemReport.ApplicationCore.Interfaces.Services;
using SystemReport.ApplicationCore.Util;

namespace SystemReport.UI.Web.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UsersController : Controller
    {
        private readonly IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        [AllowAnonymous]
        [HttpPost("authenticate")]
        public IActionResult Authenticate([FromBody]User userParam)
        {
            var user = _userService.Authenticate(userParam.Username, userParam.Password);

            if (user == null)
                return BadRequest(new { message = "Login e Senha estão incorretos!" });

            return Ok(user);
        }

        [AuthorizeRoles(Role.Admin, Role.Moderador)]
        [HttpPost("create")]
        public IActionResult CriaUsuario([FromBody]User userParam)
        {
            var user = _userService.Adicionar(userParam);

            if (user == null)
                return BadRequest(new { message = "Ops ocorreu um problema" });

            return Ok(user);
        }


        [AuthorizeRoles(Role.Admin, Role.Moderador)]
        [HttpGet("list")]
        public IActionResult GetAll()
        {
            var users = _userService.ObterTodos();
            return Ok(users);
        }



        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var user = _userService.ObterPorId(id);

            if (user == null)
            {
                return NotFound();
            }

            // only allow admins to access other user records
            var currentUserId = int.Parse(User.Identity.Name);
            if (id != currentUserId && !User.IsInRole(Role.Admin))
            {
                return Forbid();
            }

            return Ok(user);
        }


        [AuthorizeRoles(Role.Admin, Role.Moderador)]
        [HttpGet("moderador")]
        public IActionResult Moderador()
        {
            var users = _userService.ObterTodos();
            return Ok(users);
        }

    }
}