using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VotingConsole.Service.Implementations;
using VotingConsole.Service.Interfaces;

namespace VotingConsole.Menu
{
    public class MainMenu
    {
        IUserService userService = new UserService();
        IContestantService contestantService = new ContestantService();
        IElectionService electionService = new ElectionService();
        public void Main()
        {
            Console.WriteLine("press 1 to login\npress 2 to contest");
            string opt = Console.ReadLine();
            if(opt == "1")
            {
                LoginMenu();
            }
            else if(opt == "2")
            {
                ContestMenu();
                Main();
            }
            else
            {
                Console.WriteLine("invalid input");
                Main();
            }
           


        }

        public void LoginMenu()
        {
            Console.Write("enter your email: ");
            string email = Console.ReadLine();
            Console.Write("enter your password: ");
            string password = Console.ReadLine();

            var login = userService.Login(email, password);
            if (login != null)
            {
                if (login.Role == "Chairman")
                {
                    ChairmanMenu menu = new ChairmanMenu();
                    menu.Chairman();
                }
                else if (login.Role == "Contestant")
                {

                }
                else if (login.Role == "Student")
                {

                }
            }
        }

        public void ContestMenu()
        {
            Console.Write("enter your nick name: ");
            string nick = Console.ReadLine();
            
            Console.Write("enter your matric number: ");
            string matric = Console.ReadLine();

            var elections = electionService.GetAll();
            foreach (var item in elections)
            {
                Console.WriteLine($"enter {item.Name} to contest in {item.Name} election");
            }

            string electionName = Console.ReadLine();

            var election = electionService.Get(electionName);

            foreach (var item in election.Positions)
            {
                Console.WriteLine($"enter {item.Name} to contest for {item.Name} position in {electionName} election");
            }
            var positionName = Console.ReadLine();

            contestantService.Create(nick,matric,electionName,positionName);    

        }
    }
}
