using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VotingConsole.Models;

namespace VotingConsole.Repositories.Interfaces
{
    public interface IContestantRepository
    {
        void Create(Contestant obj);
        Contestant Get(string nickName);
        List<Contestant> GetAll();
    }
}
