using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VotingConsole.Models
{
    public class Profile : BaseEntity
    {
        public string Name;
        public string PhoneNumber;
        public string Email;


        public Profile(int id, string name, string phoneNumber, string email, bool isDeleted) : base(id, isDeleted)
        {
            Name = name;
            PhoneNumber = phoneNumber;
            Email = email;
        }


    }
}
