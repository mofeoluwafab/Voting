﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VotingConsole.Models;

namespace VotingConsole.Repositories.Interfaces
{
    public interface IStudentRepository
    {
        Student Get(string matricNumber);
        List<Student> GetAll();
    }
}
