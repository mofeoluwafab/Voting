using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VotingConsole.Context;
using VotingConsole.Models;
using VotingConsole.Service.Implementations;
using VotingConsole.Service.Interfaces;

namespace VotingConsole.Menu
{
    public class ChairmanMenu
    {
        IElectionService electionService = new ElectionService();
        public void Chairman()
        {
            Console.WriteLine("press 1 to create election\npress 2 to view contestants of an election\npress 3 to view votes of an election\npress 4 to announce result\npress 5 to view all students\npress 0 to go back\npress # to logout");
            string opt = Console.ReadLine();
            if(opt == "1")
            {
                ElectionMenu();
                Chairman();
            }
            else if (opt == "2")
            {
                ContestnatsMenu();
                Chairman();
            }
            else if (opt == "3")
            {

            }
            else if (opt == "4")
            {

            }
            else if (opt == "5")
            {

            }
            else if (opt == "0")
            {

            }
            else if (opt == "#")
            {

            }
        }

        public void ElectionMenu()
        {
            Console.Write("enter the name of the election: ");
            string name = Console.ReadLine();
            Console.WriteLine($"register positions for {name} election");

            List<Position> positions = new List<Position>();

            bool flag = true;
            int count = 1;

            while (flag)
            {
                Console.Write("enter position name: ");
                string postName = Console.ReadLine();
                Console.Write("enter position minimum GP: ");
                double minGp = double.Parse(Console.ReadLine());
                Console.Write("enter position minimum level: ");
                int minLevel = int.Parse(Console.ReadLine());

                var position = new Position(count, name, postName, minGp, minLevel, new List<Contestant>(), false);
                count++;
                positions.Add(position);

                Console.Write("do you want to add another position (y/n): ");
                string opt = Console.ReadLine();
                if(opt == "y")
                {
                    flag = true;
                }
                else if (opt == "n")
                {
                    flag = false;
                }
            }

            electionService.Create(name, positions);
        }

        public void ContestnatsMenu()
        {
            var elections = electionService.GetAll();
            foreach (var item in elections)
            {
                Console.WriteLine($"enter {item.Name} to view contestants ");
            }
            string name = Console.ReadLine();

            var election = electionService.Get(name);

            foreach (var item in election.Positions)
            {
                Console.WriteLine($"contestants for {item.Name} are:");
                foreach (var item1 in item.Contestants)
                {
                    Console.WriteLine($"\t{item1.NickName}");
                }
            }
        }
    }
}
