using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VotingConsole.Models
{
    public class Result : BaseEntity
    {
        public string ReferenceNumber;
        public string ElectionName;
        public Dictionary<string, Dictionary<string, int>> Votes;


        public Result(int id, string referenceNumber, string electionName, Dictionary<string, Dictionary<string, int>> votes, bool isDeleted) : base(id, isDeleted)
        {
            ReferenceNumber = referenceNumber;
            ElectionName = electionName;
            Votes = votes;
        }


    }
}
