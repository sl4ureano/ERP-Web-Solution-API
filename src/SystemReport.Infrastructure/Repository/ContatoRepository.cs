using SystemReport.ApplicationCore.Entity;
using SystemReport.ApplicationCore.Interfaces.Repository;
using SystemReport.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SystemReport.Infrastructure.Repository
{
    public class ContatoRepository : EFRepository<Contato>, IContatoRepository
    {
        public ContatoRepository(ClienteContext dbContext) : base(dbContext)
        {

        }
    }
}
