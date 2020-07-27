using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection.Metadata;

namespace Lab4._2_Movies
{
    class Movie
    {
        private string title;
        private string category;
        private int runTime;
        private int yearRelease;

        public string Title
        {
            get
            {
                return title;
            }
            set
            {
                title = value;
            }
        }
        public string Catagory
        {
            get
            {
                return category;
            }
            set
            {
                category = value;
            }
        }
        public int RunTime
        {
            get
            {
                return runTime;
            }
            set
            {
                runTime = value;
            }
        }
        public int YearRelease
        {
            get
            {
                return yearRelease;
            }
            set
            {
                yearRelease = value;
            }
        }

        public Movie(string theTitle, string theCatagory, int theYear, int theRunTime)
        {
            title = theTitle;
            category = theCatagory;
            runTime = theRunTime;
            yearRelease = theYear;
        }

    }
    class Program
    {
        static void Main()
        {
            List<Movie> movieList = new List<Movie>();

            movieList.Add(new Movie("Fear and Loathing in Las Vegas", "Drama", 1998, 118));
            movieList.Add(new Movie("The Fourth Kind", "Drama", 2009, 98));
            movieList.Add(new Movie("The Hunger Games", "Drama", 2012, 142));
            movieList.Add(new Movie("Avatar", "SciFi", 2009, 162));
            movieList.Add(new Movie("Star Wars", "SciFi", 1987, 148));
            movieList.Add(new Movie("Tremors", "SciFi", 1990, 96));
            movieList.Add(new Movie("John Wick", "Action", 2014, 101));
            movieList.Add(new Movie("Die Hard", "Action", 1988, 132));
            movieList.Add(new Movie("Die Hard 2", "Action", 1990, 124));
            movieList.Add(new Movie("Vegas Vacation", "Comedy", 1997, 93));
            movieList.Add(new Movie("Christmas Vacation", "Comedy", 1989, 97));
            movieList.Add(new Movie("European Vacation", "Comedy", 1985, 95));

            allTheGoodStuff(movieList);
            doAgain();
        }

        static void allTheGoodStuff(List<Movie> movieList)  //take user input, verify input, display output of movies
        {
            Console.WriteLine("What catagory would you like to see?");
            Console.WriteLine("1. Action");
            Console.WriteLine("2. Comedy");
            Console.WriteLine("3. Drama");
            Console.WriteLine("4. Scifi");
            string userInput = Console.ReadLine().ToLower();
            Console.WriteLine("");
            //validate the input is only desired category or number
            List<string> categories = new List<string> { "action", "comedy", "drama", "scifi", "1", "2", "3", "4" };
            while (!categories.Contains(userInput))
            {
                Console.WriteLine("Invalid input, Please enter valid input");
                userInput = Console.ReadLine().ToLower();
            }
            //choose the movie based on number
            if (userInput == "1")
            {
                userInput = "Action";
                Console.WriteLine($"Movies that fall under the category of {userInput}:");

                foreach (Movie movie in movieList)
                {
                    movieList.Sort();
                    if (movie.Catagory.ToLower() == "action")
                    {
                        Console.WriteLine($"{movie.Title} {movie.YearRelease} {movie.RunTime}");
                    }

                }
            }
            if (userInput == "2")
            {
                userInput = "Comedy";
                Console.WriteLine($"Movies that fall under the category of {userInput}:");

                foreach (Movie movie in movieList)
                {
                    if (movie.Catagory.ToLower() == "comedy")
                    {
                        Console.WriteLine($"{movie.Title} {movie.YearRelease} {movie.RunTime}");
                    }

                }
            }
            if (userInput == "3")
            {
                userInput = "Drama";
                Console.WriteLine($"Movies that fall under the category of {userInput}:");

                foreach (Movie movie in movieList)
                {
                    if (movie.Catagory.ToLower() == "drama")
                    {
                        Console.WriteLine($"{movie.Title} {movie.YearRelease} {movie.RunTime}");
                    }

                }
            }
            if (userInput == "4")
            {
                userInput = "Scifi";
                Console.WriteLine($"Movies that fall under the category of {userInput}:");

                foreach (Movie movie in movieList)
                {
                    if (movie.Catagory.ToLower() == "scifi")
                    {
                        Console.WriteLine($"{movie.Title} {movie.YearRelease} {movie.RunTime}");
                    }

                }
            }
            //run through the movies by catagory
            foreach (Movie movie in movieList)
            {
                if (movie.Catagory.ToLower() == userInput)
                {
                    Console.WriteLine($"{movie.Title} {movie.YearRelease} {movie.RunTime}");
                }

            }
        }
        static void doAgain()
        {

            Console.WriteLine("Would you like to continue? (y/n)");
            string doAgainChoice = Console.ReadLine();
            doAgainChoice.ToLower();

            if (doAgainChoice == "y")
            {                
                Main();
            }
            else if (doAgainChoice == "n")
            {
                Console.Clear();
                Console.WriteLine("Thanks for playing");
            }
            else
            {
                Console.WriteLine("This is not valid input please try again");
                doAgain();
            }

        }
    }
}
