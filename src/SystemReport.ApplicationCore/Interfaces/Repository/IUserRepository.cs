using System;
using System.Collections.Generic;
using System.Text;
using SystemReport.ApplicationCore.Entity;

namespace SystemReport.ApplicationCore.Interfaces.Repository
{
    public interface IUserRepository : IRepository<User>
    {
        User Authenticate(string username, string password);
    }
}
