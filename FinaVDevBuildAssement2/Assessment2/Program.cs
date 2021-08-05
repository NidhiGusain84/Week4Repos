using System;
using System.Collections.Generic;

namespace Assessment2
{
    class Program
    {
        static void Main(string[] args)
        {
            int response;
            string choice;           
            string itemRemove;
            bool itemExist;
            string removeItem;
            bool finalChoice = false;

            List<string> itemList = new List<string>();
            itemList.Add("broccoli");
            itemList.Add("tomatoes");
            itemList.Add("zucchini");

            do
            {
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("[1]Add Items [2]Remove an Item [3]View Inventory: ");
                Console.WriteLine("--------------------------------------------------");

               

                do
                {
                    Console.WriteLine("Please enter 1, 2, or 3.");
                    string strResponse = Console.ReadLine();
                    int.TryParse(strResponse, out response);
                } while (response != 1 && response != 2 && response != 3);


                if (response == 1)
                {
                    Console.WriteLine("Number of items to add: ");
                    string strItems = Console.ReadLine();
                    int numItems;
                    int.TryParse(strItems, out numItems);
                    for (int i = 1; i <= numItems; i++)
                    {
                        Console.Write($"Item {i}: ");
                        string strItem = Console.ReadLine().ToLower();
                        itemList.Add(strItem);
                    }
                    Console.WriteLine();

                    Console.WriteLine("Return to the menu (y/n): ");
                    choice = Console.ReadLine();

                    while (choice != "y" && choice != "n")
                    {
                        Console.WriteLine("Please enter \"y\" or \"n\"");
                        choice = Console.ReadLine();
                    }
                    if (choice == "y")
                    {
                        continue;                        
                    }
                    else
                    {
                        Console.WriteLine("Goodbye!");
                        return;
                    }

                }
           
                if (response == 2)
                {
                    do
                    {
                        Console.WriteLine("Item to remove: ");
                        itemRemove = Console.ReadLine().ToLower();
                        itemExist = itemList.Contains(itemRemove);
                        

                        while (itemExist == false)
                        {
                            Console.WriteLine("Sorry, this item is not present.");
                            Console.WriteLine("Item to remove: ");
                            itemRemove = Console.ReadLine();
                            itemExist = itemList.Contains(itemRemove);
                        }

                        itemList.Remove(itemRemove);
                        Console.WriteLine($"{itemRemove} is removed form the inventory.");

                        Console.WriteLine("Would you like to remove another item? (y/n): ");
                        removeItem = Console.ReadLine();

                        while (removeItem != "y" && removeItem != "n")
                        {
                            Console.WriteLine("Please enter \"y\" or \"n\"");
                            removeItem = Console.ReadLine();
                        }

                    } while (removeItem == "y");

                    Console.WriteLine("Return to the menu (y/n): ");
                    choice = Console.ReadLine();

                    while (choice != "y" && choice != "n")
                    {
                        Console.WriteLine("Please enter \"y\" or \"n\"");
                        choice = Console.ReadLine();
                    }
                    if (choice == "y")
                    {
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("Goodbye!");
                        return;
                    }

                }
                if (response == 3)
                {
                    for (int i = 0; i < itemList.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}: {itemList[i]}");
                    }

                    Console.WriteLine("Return to the menu (y/n): ");
                    choice = Console.ReadLine();

                    while (choice != "y" && choice != "n")
                    {
                        Console.WriteLine("Please enter \"y\" or \"n\"");
                        choice = Console.ReadLine();
                    }
                    if (choice == "y")
                    {
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("Goodbye!");
                        return;
                    }

                }

            } while (!finalChoice);
         
        }
    }
}
