using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VotingConsole.Models;

namespace VotingConsole.Service.Interfaces
{
    public interface IUserService
    {
        User Login(string email, string pin);
        User Get(string email);
        List<User> GetAll();
    }
}
