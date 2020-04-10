using _01_Cafe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_CafeUI
{
    class ProgramUi
    {
        private readonly MenuRepo _menuRepo = new MenuRepo();

        public void Run()
        {
            RunMenu();
        }


        private void RunMenu()
        {
            bool continueToRun = true;
            while(continueToRun)
            {
                Console.Clear();
                Console.WriteLine("Enter a number to select an option: \n" +
                    "1. Show entire menu \n" +
                    "2. Get meal by name\n" +
                    "3. Add new meal to menu \n" +
                    "4. Delete meal \n" +
                    "5. Exit");
                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        {
                            ShowMenu();
                            break;
                        }
                    case "2":
                        {
                            ShowByName();
                            break;
                        }
                    case "3":
                        {
                            MakeNewMeal();
                            break;
                        }
                    case "4":
                        {
                            RemoveMeal();
                            break;

                        }
                    case "5":
                        {
                            continueToRun = false;
                            break;
                        }
                    default:
                        {
                            break;
                        }
                }
            }


        }

        private void ShowMenu()
        {
            Console.Clear();
            List<Menu> listOfMenu = _menuRepo.GetItem();

            foreach(Menu menu in listOfMenu)
            {
                DisplayMenu(menu);
            }
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        private void DisplayMenu(Menu menu)
        {
            Console.WriteLine($"MealName:{menu.MealName}\n" +
                $"MealNumber: {menu.MealNumber}\n" +
                $"Description: {menu.Description}\n" +
                $"Ingredients:{menu.Ingredients}\n" +
                $"Price:{menu.Price}");
        }

        private void ShowByName()
        {
            Console.Clear();
            Console.WriteLine("Please enter a meal name: ");
            string name = Console.ReadLine();
            Menu foundItem = _menuRepo.GetItemByMealName(name);
            if (foundItem != null)
            {
                DisplayMenu(foundItem);
            }
            else
            {
                Console.WriteLine("Invalid Name. Could not find Meal");

            }
            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();
        }

        private void MakeNewMeal()
        {
            Console.Clear();
            Menu menu = new Menu();
            
            Console.Write("Enter a meal name: ");
            menu.MealName = Console.ReadLine();

            Console.Write("Enter meal number: ");
            menu.MealNumber = int.Parse(Console.ReadLine());

            Console.Write("Enter a description: ");
            menu.Description = Console.ReadLine();

            Console.Write("Enter ingredients: " );
            menu.Ingredients = Console.ReadLine();
            



            Console.Write("Enter price: ");
            menu.Price = Convert.ToDouble(Console.ReadLine());

            bool added = _menuRepo.AddItemToDirectory(menu);
            if (added)
            {
                Console.WriteLine("Your Content has been added \n" +
                                    "Press any key to continue");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("There has been an error, please try again");
                Console.ReadKey();
            }
        
        }
        
        private void RemoveMeal()
        {
            Console.WriteLine("Which meal would you like to remove?...");
            List<Menu> menuList = _menuRepo.GetItem();
            int count = 0;
            foreach (Menu menu in menuList)
            {
                count++;
                Console.WriteLine($"{count} -{menu.MealName}");

            }

            int targetMenuId = int.Parse(Console.ReadLine());
            int targetIndex = targetMenuId - 1;
            if (targetIndex >= 0 && targetIndex < menuList.Count)
            {
                Menu desiredMenu = menuList[targetIndex];
                if (_menuRepo.DeleteExistingItem(desiredMenu))
                {
                    Console.WriteLine($"{desiredMenu.MealName} has been removed");
                }
                else
                {
                    Console.WriteLine("I'm afraid I can't do that.");
                }
            }
            else
            {
                Console.WriteLine("No content had that ID.");
            }
            Console.WriteLine("Press any key to continue....");
            Console.ReadKey();
        }
    }
}
