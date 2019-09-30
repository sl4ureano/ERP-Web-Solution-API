using System;
using System.Collections.Generic;
using System.Text;
using SystemReport.ApplicationCore.Entity;

namespace SystemReport.ApplicationCore.Interfaces.Services
{
    public interface IUserService : IService<User>
    {
        User Authenticate(string username, string password);
    }
}
