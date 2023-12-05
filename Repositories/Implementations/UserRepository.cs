using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VotingConsole.Context;
using VotingConsole.Models;
using VotingConsole.Repositories.Interfaces;

namespace VotingConsole.Repositories.Implementations
{
    public class UserRepository : IUserRepository
    {

        public User Get(string email)
        {
            foreach (var item in VotingContext.UserDb)
            {
                if(item.Email == email && item.IsDeleted == false)
                {
                    return item;
                }
            }
            return null;
        }

        public List<User> GetAll()
        {
            return VotingContext.UserDb;
        }

        public User GetByEmailAndPin(string email, string password)
        {
            foreach (var item in VotingContext.UserDb)
            {
                if (item.Email == email && item.Pin == password && item.IsDeleted == false)
                {
                    return item;
                }
            }
            return null;
        }
    }
}
