using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VotingConsole.Models;

namespace VotingConsole.Service.Interfaces
{
    public interface IProfileService
    {
        Profile Get(string phoneNumber);
        List<Profile> GetAll();
    }
}
