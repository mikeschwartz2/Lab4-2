using System;
using System.Collections.Generic;

namespace Lab4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Movie> movies = new List<Movie>();
            string rerun = "";

            movies.Add(new Movie(1, "Avengers", "action", 120, 2012));
            movies.Add(new Movie(1, "John Wick", "action", 90, 2014));
            movies.Add(new Movie(1, "Batman", "action", 130, 2010));
            movies.Add(new Movie(2, "It Follows", "horror", 80, 2014));
            movies.Add(new Movie(2, "The Babadook", "horror", 100, 2014));
            movies.Add(new Movie(2, "Human Centepede", "horror", 110, 2009));
            movies.Add(new Movie(3, "Deadpool", "comedy", 160, 2016));
            movies.Add(new Movie(3, "Anchorman", "comedy", 115, 2004));
            movies.Add(new Movie(3, "Dodgeball", "comedy", 95, 2001));
            movies.Add(new Movie(4, "Lego Movie", "animation", 120, 2012));
            movies.Add(new Movie(4, "How to Train Your Dragon", "animation", 120, 2012));
            movies.Add(new Movie(4, "Monsters Inc", "animation", 120, 2012));

            do
            {

                DisplayCat(movies);

                CatSearch(movies);

                rerun = Rerun(rerun);
            }
            while (rerun == "y");
        }

        static string MenuCheck(string search)
        {
            if (search == "1")
            {
                search = "action";
            }
            else if (search == "2")
            {
                search = "horror";
            }
            else if (search == "3")
            {
                search = "comedy";
            }
            else if (search == "4")
            {
                search = "animation";
            }
            return search;
        }

        static void DisplayCat(List<Movie> movies)
        {
            int i = 0;
            Console.WriteLine("=========================================");
            Console.WriteLine("           Category List");
            Console.WriteLine("=========================================");

            foreach (Movie m in movies)
            {
                if (m.CatCount != i)
                {
                    Console.WriteLine($"{m.CatCount}: {m.Category}");
                    i++;
                }
            }
        }

        static void CatSearch(List<Movie> movies)
        {
            bool catCheck = false;
            while (!catCheck)
            {
                Console.Write("Please enter category to search for: ");
                string search = Console.ReadLine().ToLower();

                search = MenuCheck(search);

                foreach (Movie m in movies)
                {
                    if (m.Category.Contains(search))
                    {
                        Console.WriteLine(m);
                        catCheck = true;
                    }
                }
                if (!catCheck)
                {
                    Console.WriteLine("This is not a vailid category!");
                }
            }
        }

        static string Rerun(string rerun)
        {
            Console.WriteLine("Would you like to search for another category? y/n");
            rerun = Console.ReadLine();
            rerun = rerun.ToLower();

            while (rerun != "y" && rerun != "n")
            {
                Console.WriteLine("This is not a valid input. Would you like to search again: y/n");
                rerun = Console.ReadLine();
                rerun = rerun.ToLower();
            }
            return rerun;
        }
    }
}
