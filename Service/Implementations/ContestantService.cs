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
    public class ContestantService : IContestantService
    {
        IStudentRepository studentRepository = new StudentRepository();
        IContestantRepository contestantRepository = new ContestantRepository();
        IElectionRepository electionRepository = new ElectionRepository();
        IPositionRepository positionRepository = new PositionRepository();
        IUserRepository userRepository = new UserRepository();
        public Contestant Create(string nickName, string matricNumber, string electionName, string positionName)
        {
            var student = studentRepository.Get(matricNumber);
            var election = electionRepository.Get(electionName);
            var position = positionRepository.Get(positionName);

            if(student.GP >= position.MinGP && student.Level >= position.MinLevel)
            {
                var user = userRepository.Get(student.UserEmail);
                user.Role = "Contestant";

                var id = VotingContext.ContestantDb.Count + 1;
                Contestant contestant = new Contestant(id, nickName, matricNumber, electionName, positionName, false);

                VotingContext.ContestantDb.Add(contestant);
                position.Contestants.Add(contestant);
                return contestant;
            }
            return null;
        }

        public Contestant Get(string nickName)
        {
            throw new NotImplementedException();
        }

        public List<Contestant> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
