using Badges;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_BadgeUI
{
    public class ProgramUI
    {
        private readonly BadgeRepo _badgeRepo = new BadgeRepo();
        public void Run()
        {
            RunMenu();
        }


        private void RunMenu()
        {
            bool continueToRun = true;
            while (continueToRun)

            {


                Console.Clear();
                Console.WriteLine("Hello Security Admin, What would you like to do? \n" +
                    "1. Add a badge. \n" +
                    "2. Edit a badge. \n" +
                    "3. List all badges. \n");
                String userinput = Console.ReadLine();

                switch (userinput)
                {
                    case "1":
                        AddNewBadge();
                        break;
                    case "2":
                        EditBadge();
                        break;
                    case "3":
                        ListBadges();
                        break;
                }


            }
        }

        public void AddNewBadge()
        {
            Badge badge = new Badge();

            Console.WriteLine("Waht is the number on the badge:");
            badge.BadgeID = int.Parse(Console.ReadLine());

            Console.WriteLine("List a door that i needs access to:");
            badge.DoorNames = (Console.ReadLine());



            
        }
        public void EditBadge()
        {
        }
        public void ShowAll(Badge badges)
        {
            Console.WriteLine($"Key\n" +
                $"Badge #: \n{badges.BadgeID}");
        }

        public void ListBadges ()
        {
            List<Badge> listOfBadges = _badgeRepo.GetBadges();
            foreach (Badge badge in listOfBadges)
            {
                ShowAll(badge);
            }
            
        }

    }
}
