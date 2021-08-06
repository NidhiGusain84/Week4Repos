using System;
using System.Collections.Generic;

namespace Lab4_2Movies
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Movie> moviesList = new List<Movie>();
            Movie m1 = new Movie("Toy Story", "Animated");
            Movie m2 = new Movie("Boogie Nights", "Drama");
            Movie m3 = new Movie("Coco", "Animated");
            Movie m4 = new Movie("Host 1", "Horror");
            Movie m5 = new Movie("Srar Wars", "Scifi");
            Movie m6 = new Movie("Citizen Kane", "Drama");
            Movie m7 = new Movie("Host 2", "Horror");
            Movie m8 = new Movie("His House", "Drama");
            Movie m9 = new Movie("Finding Dory", "Animated");
            Movie m10 = new Movie("12 Angry Men", "Drama");
            Movie m11 = new Movie("Possessor", "Horror");
            Movie m12 = new Movie("Up", "Animated");
            Movie m13 = new Movie("Aliens", "Scifi");
            Movie m14 = new Movie("Blade Runner", "Scifi");


            moviesList.Add(m1);
            moviesList.Add(m2);
            moviesList.Add(m3);
            moviesList.Add(m4);
            moviesList.Add(m5);
            moviesList.Add(m6);
            moviesList.Add(m7);
            moviesList.Add(m8);
            moviesList.Add(m9);
            moviesList.Add(m10);
            moviesList.Add(m11);
            moviesList.Add(m12);
            moviesList.Add(m13);
            moviesList.Add(m14);

            Console.WriteLine("Welcome to the Movie List Application!");
            Console.WriteLine($"\n\n There are {moviesList.Count} movies in this list.");

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
                Console.Write("\n\nContinue? (y/n)");
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
