using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VotingConsole.Models
{
    public class Student : BaseEntity
    {
        public string UserEmail;
        public int Level;
        public double GP;
        public string Department;
        public string MatricNumber;
        public bool HasVoted;


        public Student(int id,string email, int level, double gP, string department, string matricNumber, bool hasVoted, bool isDeleted) : base(id, isDeleted)
        {
            UserEmail = email;
            Level = level;
            GP = gP;
            Department = department;
            MatricNumber = matricNumber;
            HasVoted = hasVoted;
        }


    }
}
