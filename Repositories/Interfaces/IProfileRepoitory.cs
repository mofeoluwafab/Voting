using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VotingConsole.Models;

namespace VotingConsole.Repositories.Interfaces
{
    public interface IProfileRepoitory
    {
        Profile Get(string phone);
        List<Profile> GetAll();
    }
}
