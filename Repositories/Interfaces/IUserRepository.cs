using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VotingConsole.Models;

namespace VotingConsole.Repositories.Interfaces
{
    public interface IUserRepository
    {
        User Get(string email);
        User GetByEmailAndPin(string email, string password);
        List<User> GetAll();
    }
}
