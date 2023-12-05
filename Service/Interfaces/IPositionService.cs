using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VotingConsole.Models;

namespace VotingConsole.Service.Interfaces
{
    public interface IPositionService
    {
        Position Create(string electionName, string name, double minGP, int minLevel);
        Position Get(string name);
        List<Position> GetAll();
        bool Delete(string name);
    }
}
