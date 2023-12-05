using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VotingConsole.Models;

namespace VotingConsole.Service.Interfaces
{
    public interface IElectionService
    {
        Election Create(string name, List<Position> positions);
        Election Get(string name);
        List<Election> GetAll();
        bool Delete(string name);
    }
}
