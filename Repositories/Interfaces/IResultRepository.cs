using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VotingConsole.Models;

namespace VotingConsole.Repositories.Interfaces
{
    public interface IResultRepository
    {
        void Create(Result obj);
        Result Get(string refNo);
        List<Result> GetAll();
    }
}
