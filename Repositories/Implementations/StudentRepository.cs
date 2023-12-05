using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VotingConsole.Context;
using VotingConsole.Models;
using VotingConsole.Repositories.Interfaces;

namespace VotingConsole.Repositories.Implementations
{
    public class StudentRepository : IStudentRepository
    {

        public Student Get(string matricNumber)
        {
            foreach (var item in VotingContext.StudentDb)
            {
                if(item.MatricNumber == matricNumber && item.IsDeleted == false)
                {
                    return item;
                }
            }
            return null;
        }

        public List<Student> GetAll()
        {
            return VotingContext.StudentDb;
        }

    }
}
