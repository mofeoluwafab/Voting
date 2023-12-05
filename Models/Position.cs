using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VotingConsole.Models
{
    public class Position : BaseEntity
    {
        public string ElectionName;
        public string Name;
        public double MinGP;
        public int MinLevel;
        public List<Contestant> Contestants;


        public Position(int id, string electionName, string name, double minGP, int minLevel, List<Contestant> contestants, bool isDeleted) : base(id, isDeleted)
        {
            ElectionName = electionName;
            Name = name;
            MinGP = minGP;
            MinLevel = minLevel;
            Contestants = contestants;
        }


    }
}
