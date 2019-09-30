using SystemReport.ApplicationCore.Entity;
using SystemReport.ApplicationCore.Interfaces.Repository;
using SystemReport.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SystemReport.Infrastructure.Repository
{
    public class ClienteRepository : EFRepository<Cliente>, IClienteRepository
    {
        public ClienteRepository(ClienteContext dbContext) : base(dbContext)
        {

        }

        public Cliente ObterPorProfissao(int clienteID)
        {
            return Buscar(x => x.ProfissoesClientes.Any(p => p.ClienteId == clienteID))
                .FirstOrDefault();
        }

    }
}
