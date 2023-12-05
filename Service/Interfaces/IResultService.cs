using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VotingConsole.Models;

namespace VotingConsole.Service.Interfaces
{
    public interface IResultService
    {
        Result Create(string electionName, Dictionary<string, Dictionary<string, int>> votes);
        Result Get(string refNumber);
        List<Result> GetAll();
    }
}
