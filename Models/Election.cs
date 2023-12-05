using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VotingConsole.Enums;

namespace VotingConsole.Models
{
    public class Election : BaseEntity
    {
        public string RefNumber;
        public string Name;
        public List<Position> Positions;
        public List<Voting> Votes;
        public Dictionary<string, Dictionary<string, int>> Result;
        public ElectionStatus ElectionStatus;

        public Election(int id, string refNumber, string name,  List<Position> positions, List<Voting> votes, Dictionary<string, Dictionary<string, int>> result, ElectionStatus electionStatus,bool isDeleted) : base(id, isDeleted)
        {
            RefNumber = refNumber;
            Name = name;
            Positions = positions;
            Votes = votes;
            Result = result;
            ElectionStatus = electionStatus;
        }
    }
}
