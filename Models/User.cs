using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VotingConsole.Models
{
    public class User : BaseEntity
    {
        public string Email;
        public string Pin;
        public string Role;

        public User(int id,string email, string pin, string role, bool isDeleted) : base(id, isDeleted)
        {
            Email = email;
            Pin = pin;
            Role = role;
        }
    }
}
