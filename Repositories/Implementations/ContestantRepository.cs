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
    public class ContestantRepository : IContestantRepository
    {
        public void Create(Contestant obj)
        {
            VotingContext.ContestantDb.Add(obj);
        }

        public Contestant Get(string Name)
        {
            foreach (var item in VotingContext.ContestantDb)
            {
                if(item.Name == Name && item.IsDeleted == false)
                {
                    return item;
                }
            }
            return null;
        }

        public List<Contestant> GetAll()
        {
            return VotingContext.ContestantDb;
        }
    }
}
