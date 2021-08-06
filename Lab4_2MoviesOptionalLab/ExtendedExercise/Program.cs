using System;
using System.Collections.Generic;
using System.Linq;

namespace ExtendedExercise
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
            Console.WriteLine(m1.ToString());
           
           

            string response;
            int intres;

            do
            {
                Console.Write("What category are you interested in?: ");
                string userChoice = Console.ReadLine();
                int.TryParse(userChoice, out intres);

                while (intres != 1 && intres !=2 && intres != 3 && intres != 4)
                {
                    Console.WriteLine("\nWrong category.");
                    Console.WriteLine("Enter 1 or 2 or 3 or 4");
                    Console.Write("What category are you interested in?: ");
                    userChoice = Console.ReadLine();
                    int.TryParse(userChoice, out intres);
                }

                if (intres == 1)
                {
                   var horrorMovies = moviesList.Where(x => x.category == "Horror").ToList();
                    PrintMovies(horrorMovies);
                }
                if (intres == 2)
                {
                    var horrorMovies = moviesList.Where(x => x.category == "Scifi").ToList();
                    PrintMovies(horrorMovies);
                }
                if (intres == 3)
                {
                    var horrorMovies = moviesList.Where(x => x.category == "Drama").ToList();
                    PrintMovies(horrorMovies);
                }

                if (intres == 4)
                {
                    var horrorMovies = moviesList.Where(x => x.category == "Animated").ToList();
                    PrintMovies(horrorMovies);
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

        static void PrintMovies(List<Movie> movieList)
        {
            movieList.OrderBy(x => x.title).ToList().ForEach(x => Console.WriteLine(x.title));
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

        public override string ToString()
        {
            return $"Enter 1(horror) or 2(scifi) or 3(drama) or 4(animated)";
        }

    }
}
