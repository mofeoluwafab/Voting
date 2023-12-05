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
    public class VotingService : IVotingService
    {
        IStudentRepository studentRepository = new StudentRepository();
        IVotingRepository votingRepository = new VotingRepository();

        public Voting Create(string matricNumber, string electionName, Dictionary<string, string> vote)
        {
            var student = studentRepository.Get(matricNumber);
            if(student == null)
            {
                Console.WriteLine($"{student} not found");
                return null;

            }
            else
            {
                if (student.HasVoted == true)
                {
                    Console.WriteLine("You have already vote");
                    return null;
                }
                else
                {
                    var id = VotingContext.VotingDb.Count + 1;
                    Voting voting = new Voting(id, GenerateRefNumber(), matricNumber,electionName, vote, false);

                    votingRepository.Create(voting);
                    return voting;
                }
            }
            
        }

        private string GenerateRefNumber()
        {
            return "CLH/VOT/" + new Random().Next(1000, 9999);
        }

        public Voting Get(string refNumber)
        {
            var voting = votingRepository.Get(refNumber);   
            if(voting == null)
            {
                return null;
            }
            return voting;
        }

        public List<Voting> GetAll()
        {
            return votingRepository.GetAll();
        }
    }
}
