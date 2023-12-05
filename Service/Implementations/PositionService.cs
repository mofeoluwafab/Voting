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
    public class PositionService : IPositionService
    {
        IPositionRepository positionRepository = new PositionRepository();
        public Position Create(string electionName, string name, double minGP, int minLevel)
        {
            var exists = positionRepository.Get(name);
            if (exists != null)
            {
                Console.WriteLine($"{name} already exist");
                return null;
            }

            var id = VotingContext.ElectionDb.Count + 1;
            Position position = new Position(id,electionName, name, minGP, minLevel,new List<Contestant>(), false);

            positionRepository.Create(position);    
            return position;
        }


        public bool Delete(string name)
        {
            var position = positionRepository.Get(name);
            if (position == null)
            {
                Console.WriteLine($"{name} not found");
                return false;
            }
            position.IsDeleted = true;
            return true;
        }

        public Position Get(string name)
        {
            var position = positionRepository.Get(name);
            if (position == null)
            {
                Console.WriteLine($"{name} not found");
                return null;
            }
            return position;
        }

        public List<Position> GetAll()
        {
            return positionRepository.GetAll();
        }
    }
}
