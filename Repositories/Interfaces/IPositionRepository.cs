using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VotingConsole.Models;

namespace VotingConsole.Repositories.Interfaces
{
    public interface IPositionRepository
    {
        void Create(Position obj);
        Position Get(string name);
        List<Position> GetAll();
    }
}
