using System;
using System.Collections.Generic;
using System.Linq;

namespace ExtendedExercise
{
     class Program
    {
        static void Main(string[] args)
        {
            List<Movie> moviesList = new List<Movie>() {
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
            new Movie("Blade Runner", "Scifi") };

            moviesList.Add(new Movie("Moana", "Animated"));

            

            Console.WriteLine("Welcome to the Movie List Application!");
            Console.WriteLine($"\n\n There are {moviesList.Count} movies in this list.");
           
           
           

            string response;
            int num;

            do
            {
                Console.Write("What category are you interested in?: ");
                string userChoice = Console.ReadLine();
                int.TryParse(userChoice, out num);

                while (num != 1 && num !=2 && num != 3 && num != 4)
                {
                    Console.WriteLine("\nWrong category.");
                    Console.WriteLine("Enter 1 or 2 or 3 or 4");
                    Console.Write("What category are you interested in?: ");
                    userChoice = Console.ReadLine();
                    int.TryParse(userChoice, out num);
                }

                if (num == 1)
                {
                   var horrorMovies = moviesList.Where(x => x.category == "Horror").ToList();
                    PrintMovies(horrorMovies);
                }
                if (num == 2)
                {
                    var horrorMovies = moviesList.Where(x => x.category == "Scifi").ToList();
                    PrintMovies(horrorMovies);
                }
                if (num == 3)
                {
                    var horrorMovies = moviesList.Where(x => x.category == "Drama").ToList();
                    PrintMovies(horrorMovies);
                }

                if (num == 4)
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
