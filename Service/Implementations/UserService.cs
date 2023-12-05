using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VotingConsole.Models;
using VotingConsole.Repositories.Implementations;
using VotingConsole.Repositories.Interfaces;
using VotingConsole.Service.Interfaces;

namespace VotingConsole.Service.Implementations
{
    public class UserService : IUserService
    {
        IUserRepository userRepository = new UserRepository();
        public User Get(string email)
        {
            var user = userRepository.Get(email);
            if (user == null)
            {
                Console.WriteLine($"{email} not found");
                return null;
            }
            return user;
        }

        public List<User> GetAll()
        {
            return userRepository.GetAll();
        }

        public User Login(string email, string pin)
        {
            var login = userRepository.GetByEmailAndPin(email, pin);
            if (login == null)
            {
                Console.WriteLine("wrong cridentials");
                return null;
            }
            return login;
        }
    }
}
