using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VotingConsole.Models;

namespace VotingConsole.Service.Interfaces
{
    public interface IContestantService
    {
        Contestant Create(string nickName, string matricNumber, string electionName, string positionName);
        Contestant Get(string nickName);
        List<Contestant> GetAll();
    }
}
