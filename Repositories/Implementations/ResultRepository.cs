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
    public class ResultRepository : IResultRepository
    {
        public void Create(Result obj)
        {
            VotingContext.ResultDb.Add(obj);
        }

        public Result Get(string refNo)
        {
            foreach (var item in VotingContext.ResultDb)
            {
                if(item.ReferenceNumber == refNo && item.IsDeleted == false)
                {
                    return item;
                }
            }
            return null;
        }

        public List<Result> GetAll()
        {
            return VotingContext.ResultDb;
        }
    }
}
