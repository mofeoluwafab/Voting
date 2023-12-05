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
    public class ElectionRepository : IElectionRepository
    {
        public void Create(Election obj)
        {
            VotingContext.ElectionDb.Add(obj);
        }

        public Election Get(string name)
        {
            foreach (var item in VotingContext.ElectionDb)
            {
                if(item.Name == name && item.IsDeleted == false)
                {
                    return item;
                }
            }
            return null;
        }

        public List<Election> GetAll()
        {
            return VotingContext.ElectionDb;
        }
    }
}
