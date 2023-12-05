using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VotingConsole.Models;

namespace VotingConsole.Service.Interfaces
{
    public interface IStudentService
    {
        Student Get(string matricNumber);
        List<Student> GetAll();
    }
}
