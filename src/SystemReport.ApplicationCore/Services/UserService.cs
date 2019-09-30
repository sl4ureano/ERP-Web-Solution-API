using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using SystemReport.ApplicationCore.Entity;
using SystemReport.ApplicationCore.Interfaces.Repository;
using SystemReport.ApplicationCore.Interfaces.Services;

namespace SystemReport.ApplicationCore.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public User Authenticate(string username, string password)
        {
            return _userRepository.Authenticate(username, password);
        }

        public IEnumerable<User> ObterTodos()
        {
            return _userRepository.ObterTodos();
        }

        public User ObterPorId(int id)
        {
            var user = _userRepository.ObterPorId(id);
            // return user without password
            if (user != null)
                user.Password = null;
            return user;
        }

        public User Adicionar(User entity)
        {
            return _userRepository.Adicionar(entity);
        }

        public void Atualizar(User entity)
        {
            _userRepository.Atualizar(entity);
        }

        public IEnumerable<User> Buscar(Expression<Func<User, bool>> predicado)
        {
            return _userRepository.Buscar(predicado);
        }

        public void Remover(User entity)
        {
            _userRepository.Remover(entity);
        }
    }
}
