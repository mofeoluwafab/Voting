using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VotingConsole.Models;
using VotingConsole.Repositories.Implementations;
using VotingConsole.Repositories.Interfaces;
using VotingConsole.Service.Interfaces;

namespace VotingConsole.Service.Implementations
{
    public class StudentService : IStudentService
    {
        IStudentRepository studentRepository = new StudentRepository();
        public Student Get(string matricNumber)
        {
            var student = studentRepository.Get(matricNumber);
            if (student == null)
            {
                Console.WriteLine($"student with number {matricNumber} not found");
                return null;
            }
            return student;
        }

        public List<Student> GetAll()
        {
            return studentRepository.GetAll();
        }
    }
}
