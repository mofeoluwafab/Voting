using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VotingConsole.Models;

namespace VotingConsole.Repositories.Interfaces
{
    public interface IElectionRepository
    {
        void Create(Election obj);
        Election Get(string name);
        List<Election> GetAll();
    }
}
