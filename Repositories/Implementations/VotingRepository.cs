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
    internal class VotingRepository : IVotingRepository
    {
        public void Create(Voting obj)
        {
            VotingContext.VotingDb.Add(obj);
        }

        public Voting Get(string refNumber)
        {
            foreach (var item in VotingContext.VotingDb)
            {
                if(item.RefNumber == refNumber && item.IsDeleted == false)
                {
                    return item;
                }
            }
            return null;
        }

        public List<Voting> GetAll()
        {
            return VotingContext.VotingDb;
        }
    }
}
