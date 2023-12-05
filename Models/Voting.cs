using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VotingConsole.Models
{
    public class Voting : BaseEntity
    {
        public string RefNumber;
        public string MatricNumber;
        public string ElectionName;
        public Dictionary<string, string> Vote;

        public Voting(int id, string refNumber, string matricNumber, string electionName,Dictionary<string, string> vote, bool isDeleted) : base(id, isDeleted)
        {
            RefNumber = refNumber;
            MatricNumber = matricNumber;
            ElectionName = electionName;
            Vote = vote;
        }
    }
}
