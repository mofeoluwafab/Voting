using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VotingConsole.Models;

namespace VotingConsole.Context
{
    public class VotingContext
    {
        public static List<Contestant> ContestantDb = new List<Contestant>();
        public static List<Election> ElectionDb = new List<Election>()
        {
            new Election(1, "SUG", new List<Position>()
            {
                new Position(1, "SUG", "President", 2.0, 200, new List<Contestant>(), false),
                new Position(2, "SUG", "VP", 2.0, 200, new List<Contestant>(), false),
                new Position(3, "SUG", "PRO", 2.0, 200, new List<Contestant>(), false)
            }, false),

            new Election(2, "OGUN", new List<Position>()
            {
                new Position(1, "OGUN", "Aare", 2.0, 200, new List<Contestant>(), false),
                new Position(2, "OGUN", "Igbakeji", 2.0, 200, new List<Contestant>(), false),
                new Position(3, "OGUN", "Akapo", 2.0, 200, new List<Contestant>(), false)
            }, false),

        };
        public static List<Profile> ProfileDb = new List<Profile>()
        {
            new Profile(1,"ade","091","a@gmail.com",false),
            new Profile(2,"ola","091","b@gmail.com",false),
            new Profile(3,"ope","091","c@gmail.com",false),
            new Profile(4,"sola","091","d@gmail.com",false),
            new Profile(5,"ini","091","e@gmail.com",false),
            new Profile(6,"obi","091","f@gmail.com",false),
            new Profile(7,"ife","091","g@gmail.com",false),
            new Profile(8,"olu","091","h@gmail.com",false),
            new Profile(9,"ire","091","i@gmail.com",false),
            new Profile(10,"ife","091","j@gmail.com",false),
        };

        public static List<Position> PositionDb = new List<Position>();
        public static List<Result> ResultDb = new List<Result>();
        public static List<Student> StudentDb = new List<Student>()
        {
            new Student(1,"a@gmail.com",200,2.5,"civil","clh/01/067",false,false),
            new Student(2,"b@gmail.com",200,3.5,"arch","clh/01/064",false,false),
            new Student(3,"c@gmail.com",200,2.48,"geo","clh/01/063",false,false),
            new Student(4,"d@gmail.com",200,1.24,"eng","clh/01/061",false,false),
            new Student(5,"e@gmail.com",200,3.57,"agric","clh/01/060",false,false),
            new Student(6,"f@gmail.com",200,2.12,"pharm","clh/01/034",false,false),
            new Student(7,"g@gmail.com",200,3.22,"agric","clh/01/023",false,false),
            new Student(8,"h@gmail.com",300,3.0,"med","clh/01/087",false,false),
            new Student(9,"i@gmail.com",200,2.22,"religion","clh/01/017",false,false),
            new Student(10,"j@gmail.com",200,4.51,"law","clh/01/097",false,false),
        };
        public static List<User> UserDb = new List<User>()
        {
            new User(1,"a@gmail.com","1234","Chairman",false),
            new User(2,"b@gmail.com","1234","Student",false),
            new User(3,"c@gmail.com","1234","Student",false),
            new User(4,"d@gmail.com","1234","Student",false),
            new User(5,"e@gmail.com","1234","Student",false),
            new User(6,"f@gmail.com","1234","Student",false),
            new User(7,"g@gmail.com","1234","Student",false),
            new User(8,"h@gmail.com","1234","Student",false),
            new User(9,"i@gmail.com","1234","Student",false),
            new User(10,"j@gmail.com","1234","Student",false),
        };
        public static List<Voting> VotingDb = new List<Voting>();
        
    }
}
