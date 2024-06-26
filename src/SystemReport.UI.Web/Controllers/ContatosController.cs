﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SystemReport.ApplicationCore.Interfaces.Services;

namespace SystemReport.UI.Web.Controllers
{
    public class ContatosController : Controller
    {
        private readonly IContatoService _contatoService;

        public ContatosController(IContatoService contatoService)
        {
            _contatoService = contatoService;
        }

        // GET: Contatos
        public ActionResult Index()
        {
            return Json(_contatoService.ObterTodos());
        }

        // GET: Contatos/Details/5
        public ActionResult Details(int id)
        {
            return Json(_contatoService.ObterPorId(id));
        }

        // GET: Contatos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Contatos/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Contatos/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Contatos/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Contatos/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Contatos/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}