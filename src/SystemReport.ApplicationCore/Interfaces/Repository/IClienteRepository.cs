using SystemReport.ApplicationCore.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace SystemReport.ApplicationCore.Interfaces.Repository
{
    public interface IClienteRepository : IRepository<Cliente>
    {
        Cliente ObterPorProfissao(int clienteID);
    }
}
