using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VotingConsole.Context;
using VotingConsole.Models;
using VotingConsole.Repositories.Implementations;
using VotingConsole.Repositories.Interfaces;
using VotingConsole.Service.Interfaces;

namespace VotingConsole.Service.Implementations
{
    public class ResultService : IResultService
    {
        IResultRepository resultRepository = new ResultRepository();
        public Result Create(string electionName, Dictionary<string, Dictionary<string, int>> votes)
        {
            int id = VotingContext.ResultDb.Count + 1;
            string refNumber = $"CLH/{electionName.Substring(0, 3)}/{new Random().Next(1000,9999)}";
            Result result = new Result(id,refNumber,electionName,votes, false);
            resultRepository.Create(result);
            return result;
        }

        public Result Get(string refNumber)
        {
            var result = resultRepository.Get(refNumber);
            if(result == null)
            {
                Console.WriteLine("result not found");
                return null;
            }
            return result;
        }

        public List<Result> GetAll()
        {
            return resultRepository.GetAll();   
        }
    }
}
