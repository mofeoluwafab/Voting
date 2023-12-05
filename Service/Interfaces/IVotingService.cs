using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VotingConsole.Models;

namespace VotingConsole.Service.Interfaces
{
    public interface IVotingService
    {
        Voting Create(string matricNumber, string electionName, Dictionary<string, string> vote);
        Voting Get(string refNumber);
        List<Voting> GetAll();
    }
}
