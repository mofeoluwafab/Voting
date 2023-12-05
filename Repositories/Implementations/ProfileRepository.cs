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
    public class ProfileRepository : IProfileRepoitory
    {

        public Profile Get(string phone)
        {
            foreach (var item in VotingContext.ProfileDb)
            {
                if(item.PhoneNumber == phone && item.IsDeleted == false)
                {
                    return item;
                }
            }
            return null;
        }

        public List<Profile> GetAll()
        {
            return VotingContext.ProfileDb;
        }
    }
}
