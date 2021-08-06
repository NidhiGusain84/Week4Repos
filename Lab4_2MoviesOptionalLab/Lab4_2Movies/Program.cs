using System;
using System.Collections.Generic;

namespace Lab4_2Movies
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Movie> moviesList = new List<Movie>()
            {
                new Movie("Toy Story", "Animated"),
                new Movie("Boogie Nights", "Drama"),
                new Movie("Toy Story", "Animated"),
                new Movie("Boogie Nights", "Drama"),
                new Movie("Coco", "Animated"),
                new Movie("Host 1", "Horror"),
                new Movie("Srar Wars", "Scifi"),
                new Movie("Citizen Kane", "Drama"),
                new Movie("Host 2", "Horror"),
                new Movie("His House", "Drama"),
                new Movie("Finding Dory", "Animated"),
                new Movie("12 Angry Men", "Drama"),
                new Movie("Possessor", "Horror"),
                new Movie("Up", "Animated"),
                new Movie("Aliens", "Scifi"),
                new Movie("Blade Runner", "Scifi")
            };

            moviesList.Add(new Movie("1946", "Horror"));

            Console.WriteLine("Welcome to the Movie List Application!");
            Console.WriteLine($"\n\nThere are {moviesList.Count} movies in this list.");

            string response;

            do
            {
                Console.Write("What category are you interested in?: ");
                string userChoice = Console.ReadLine().ToLower();

                while (userChoice != "animated" && userChoice != "drama" && userChoice != "horror" && userChoice != "scifi")
                {
                    Console.WriteLine("\nWrong category.");
                    Console.WriteLine("These are available categories: animated or drama or horror or scifi");
                    Console.Write("What category are you interested in?: ");
                    userChoice = Console.ReadLine().ToLower();
                }


                foreach (Movie item in moviesList)
                {
                    if (item.category.ToLower() == userChoice)
                    {
                        Console.WriteLine(item.title);
                    }
                }
                Console.Write("\n\nContinue? (y/n): ");
                response = Console.ReadLine().ToLower();
                while (response != "y" && response != "n")
                {
                    Console.Write("Enter y or n: ");
                    response = Console.ReadLine().ToLower();
                }

            } while (response == "y");

            Console.WriteLine("\nGoodbye!");

        }
    }

    class Movie
    {
        private string _title;
        private string _category;


        public Movie(string title, string category)
        {
            _title = title;
            _category = category;
        }
        public string title
        {
            get => _title;
            set => _title = value;
        }
        public string category
        {
            get => _category;
            set => _category = value;
        }



    }

}
