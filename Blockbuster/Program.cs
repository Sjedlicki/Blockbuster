using System;
using System.Threading;
using System.Timers;

namespace Blockbuster
{
    class Program
    {
        static void Main(string[] args)
        {
            Blockbuster blockbuster = new Blockbuster();
            VHS vhsMovie;
            DVD dvdMovie;

            while (true)
            {
                Console.Clear();

                Console.WriteLine("Welcome to GC Blockbuster!");
                Console.WriteLine("Please Select a Movie from the list:");

                Movie selectedMovie = blockbuster.CheckOut();

                selectedMovie.PrintInfo();

                Console.Write("Play Enitre Movie(w) or Play movie by scene(p) or view Scenes(s)? ");
                string response = Console.ReadLine().ToLower();


                if(response == "w")
                {
                    selectedMovie.PlayWholeMovie();
                }
                else if(response == "p")
                {
                    response = "y";
                    while (response == "y")
                    {
                        if (response == "y")
                        {
                            selectedMovie.Play();
                        }

                        Console.Write("Watch another scene? ");
                        response = Console.ReadLine().ToLower();
                    }
                }
                else if(response == "s")
                {
                    selectedMovie.PrintScenes();
                    Console.WriteLine("Enter any key to continue...");
                    Console.ReadKey();
                }
                
                if(selectedMovie is VHS)
                {
                    vhsMovie = (VHS)selectedMovie;
                    vhsMovie.Rewind();
                }

                Thread.Sleep(3000);
            }
        }
    }
}
