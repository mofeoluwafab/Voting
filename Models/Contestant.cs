using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VotingConsole.Models
{
    public class Contestant : BaseEntity
    {
        public string NickName;
        public string MatricNumber;
        public string ElectionName;
        public string PositionName;

        public Contestant(int id,string nickName, string matricNumber, string electionName, string positionName, bool isDeleted) : base(id, isDeleted)
        {
            NickName = nickName;
            MatricNumber = matricNumber;
            ElectionName = electionName;
            PositionName = positionName;
            
        }
    }
}
