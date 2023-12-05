using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VotingConsole.Context;
using VotingConsole.Enums;
using VotingConsole.Models;
using VotingConsole.Repositories.Implementations;
using VotingConsole.Repositories.Interfaces;
using VotingConsole.Service.Interfaces;

namespace VotingConsole.Service.Implementations
{
    public class ElectionService : IElectionService
    {
        IElectionRepository electionRepository = new ElectionRepository();
        public Election Create(string name, List<Position> positions)
        {
            var exists = electionRepository.Get(name);
            if (exists != null)
            {
                Console.WriteLine($"{name} already exist");
                return null;
            }

            var id = VotingContext.ElectionDb.Count+1;
            var refNumber = $"CLH/ELECTION/00{id}";
            Election election = new Election(id, refNumber, name,positions,new List<Voting>(),new Dictionary<string, Dictionary<string, int>>(),ElectionStatus.Pending, false);

            electionRepository.Create(election);
            Console.WriteLine($"{name} created successfully");
            return election;
        }

        public bool Delete(string name)
        {
            var election = electionRepository.Get(name);    
            if (election == null)
            {
                Console.WriteLine($"{name} doesn't exist");
                return false;
            }
            election.IsDeleted = true;
            Console.WriteLine($"{name} deleted successfully");
            return true;
        }

        public Election Get(string name)
        {
            var election = electionRepository.Get(name);
            if(election == null)
            {
                Console.WriteLine($"{name} not found");
                return null;
            }
            return election;
        }

        public List<Election> GetAll()
        {
            return electionRepository.GetAll();
        }
    }
}
