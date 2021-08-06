using System;
using System.Collections.Generic;

namespace MyVersionOfPracticeAssessmentWeek4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Pants> listOfPants = CreatPantsList();
            Console.WriteLine("Welcome to Nidhi's Big Barn of Pants!");

            do
            {
                Console.WriteLine("\nWhat would you like to do?");
                Console.WriteLine("1. Add pants \n2. Check availability\n3. Delete pants\n4. See all the pants");
                string strinput = Console.ReadLine();
                int input;
                int.TryParse(strinput, out input);

                switch (input)
                {
                    case 1:
                        AddPants(listOfPants);
                        break;
                    case 2:
                        CheckAvailability(listOfPants);
                        break;
                    case 3:
                        DeletePant(listOfPants);
                        break;
                    case 4:
                        ListAllPants(listOfPants);
                        break;

                    default:
                        Console.WriteLine("Invalid Input");
                        break;
                }

                Console.WriteLine("\nDo you want to continue? (y/n):");
                string choice = Console.ReadLine();


                while (choice != "y" && choice != "n")
                {
                    Console.WriteLine("Please enter y or n:");
                    choice = Console.ReadLine();
                }


                if (choice == "y")
                {
                    continue;
                }
                else
                {
                    break;
                }


            } while (true);

            Console.WriteLine("Goodbye!"); 
        }

        private static void ListAllPants(List<Pants> pantsList)
        {
            foreach(Pants p in pantsList)
            {
                Console.WriteLine(p.ToString());
            }
        }

        private static void DeletePant(List<Pants> pantsList)
        {
            Console.WriteLine("Please enter a style to delete");
            string styleToDelete = Console.ReadLine();
            Pants foundPant = FindPantByStyle(pantsList, styleToDelete);
            if (foundPant != null)
            {
                pantsList.Remove(foundPant);
                Console.WriteLine($"Pant style {styleToDelete} deleted");
            }
            else
            {
                Console.WriteLine("Style not found!");
            }


        }

        private static void CheckAvailability(List<Pants> pantsList)
        {
            Console.WriteLine("Please enter Style");
            string style = Console.ReadLine();
            Console.WriteLine("Please enter Size");
            int size = int.Parse(Console.ReadLine());
            bool itemFound = false;

            foreach (Pants p in pantsList)
            {
                if (p.GetStyle() == style && p.IsAvailable(size))
                {
                    itemFound = true;
                    break;
                }
            }
            if (itemFound)
            {
                Console.WriteLine("Item available!");
            }
            else
            {
                Console.WriteLine("Item not available!");
            }

        }
        private static Pants FindPantByStyle(List<Pants> pantList, string style)
        {
            foreach (Pants p in pantList)
            {
                if (p.GetStyle() == style)
                {
                    return p;
                }
            }
            return null;
        }

        private static void AddPants(List<Pants> pantsList)
        {
            List<int> sizes = new List<int>();
            Console.WriteLine("Please enter Style");
            string style = Console.ReadLine();
            Console.WriteLine("Please enter the number of sizes avaiable:");
            int totalSizes = int.Parse(Console.ReadLine());

            for (int i = 1; i <= totalSizes; i++)
            {
                Console.WriteLine($"Size: {i}");
                sizes.Add(int.Parse(Console.ReadLine()));
            }
            Pants newPant = new Pants(style, sizes);
            pantsList.Add(newPant);
            Console.WriteLine($"New Style {style} added.");

        }

        static List<Pants> CreatPantsList()
        {
            List<int> sizesList1 = new List<int>() { 4, 6, 10, 14, 16, 18 };
            List<int> sizesList2 = new List<int>() { 3, 7, 9, 11, 13 };
            List<int> sizesList3 = new List<int>() { 6, 8, 10, 14, 16 };
            List<int> sizesList4 = new List<int>() { 2, 8, 10, 14, 18 };

            Pants p1 = new Pants("Jeans", sizesList1);
            Pants p2 = new Pants("Cords", sizesList2);
            Pants p3 = new Pants("Sweatpants", sizesList3);
            Pants p4 = new Pants("Chinos", sizesList4);

            List<Pants> pantsList = new List<Pants>();
            pantsList.Add(p1);
            pantsList.Add(p2);
            pantsList.Add(p3);
            pantsList.Add(p4);
            return pantsList;

        }


    }

    class Pants
    {
        private string _style;
        private List<int> _sizes;

        public Pants(string style, List<int> sizes)
        {
            _style = style;
            _sizes = sizes;
        }
        public string GetStyle()
        {
            return _style;
        }
        public bool IsAvailable(int n)
        {
            return _sizes.Contains(n);
        }
        public override string ToString()
        {
            return $"Style: {_style} Sizes: {string.Join(" ", _sizes)}";
        }


    }


}
