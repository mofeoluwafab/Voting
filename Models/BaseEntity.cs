using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VotingConsole.Models
{
    public abstract class BaseEntity
    {
        public int Id;
        public bool IsDeleted;

        public BaseEntity(int id, bool isDeleted)
        {
            Id = id;
            IsDeleted = isDeleted;
        }
    }
}
