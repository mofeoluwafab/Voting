using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VotingConsole.Context;
using VotingConsole.Models;
using VotingConsole.Repositories.Interfaces;

namespace VotingConsole.Repositories.Implementations
{
    public class PositionRepository : IPositionRepository
    {
        public void Create(Position obj)
        {
            VotingContext.PositionDb.Add(obj);
        }

        public Position Get(string name)
        {
            foreach (var item in VotingContext.PositionDb)
            {
                if(item.Name == name && item.IsDeleted == false)
                {
                    return item;
                }
            }
            return null;
        }

        public List<Position> GetAll()
        {
            return VotingContext.PositionDb;
        }
    }
}
