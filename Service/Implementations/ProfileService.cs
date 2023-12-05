using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using VotingConsole.Models;
using VotingConsole.Repositories.Implementations;
using VotingConsole.Repositories.Interfaces;
using VotingConsole.Service.Interfaces;

namespace VotingConsole.Service.Implementations
{
    public class ProfileService : IProfileService
    {
        IProfileRepoitory profileRepoitory = new ProfileRepository();
        public Profile Get(string phoneNumber)
        {
            var profile = profileRepoitory.Get(phoneNumber);
            if (profile == null)
            {
                Console.WriteLine($"profile with number {phoneNumber} not found");
                return null;
            }
            return profile;
        }

        public List<Profile> GetAll()
        {
            return profileRepoitory.GetAll();
        }
    }
}
