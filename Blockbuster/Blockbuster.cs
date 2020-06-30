using System;
using System.Collections.Generic;
using System.Text;

namespace Blockbuster
{
    class Blockbuster
    {
        public List<Movie> Movies = new List<Movie>
        {
            new VHS("Jurassic Park Is Freightening In The Dark", Genre.Horror, 25, new List<string> {"Scene 1: All the dinosaurs are running wild","Scene 2: Someone let TREX out of his pen", "Scene 3: Boy! They sure don't act like barney", "Scene 4: They think that I'm their dinner not their friend!", "Scene 5: Ohhhh noooooo!!!" }),

            new VHS("Blood Sport", Genre.Action, 67, new List<string> {"Scene 1","Scene 2", "Scene 3", "Scene 4", "Scene 5" }),

            new VHS("Cool Runnings", Genre.Comedy, 88, new List<string> {"Scene 1","Scene 2", "Scene 3", "Scene 4", "Scene 5" }),

            new DVD("Saving Private Ryan",Genre.Romance, 3, new List<string> {"Scene 1","Scene 2", "Scene 3", "Scene 4", "Scene 5" }),

            new DVD("Dora The Explorer", Genre.Drama, 69, new List<string> {"Scene 1","Scene 2", "Scene 3", "Scene 4", "Scene 5" }),

            new DVD("Steve's Face", Genre.Horror, 1, new List<string> {"Scene 1: Horrifyingly Horrifying","Scene 2: It Came From Behind", "Scene 3: Don't look now", "Scene 4: The Abyss", "Scene 5: ..." })
        };

        public void PrintMovies()
        {
            for (int i = 0; i < Movies.Count; i++)
            {
                Console.WriteLine($"   {i + 1}) {Movies[i].Title}");
            }
        }

        public Movie CheckOut()
        {
            int movieSelection;

            PrintMovies();

            Console.Write("Please select a movie you want to watch: ");
            while (true)
            {
                while (!int.TryParse(Console.ReadLine(), out movieSelection))
                {
                    Console.WriteLine("Ah ah ah... You didn't say the magic word.");
                }

                if (movieSelection < 1 || movieSelection > Movies.Count)
                {
                    Console.WriteLine("Not a valid selection, please try again");
                    continue;
                }
                else
                {
                    break;
                }
            }

            return Movies[movieSelection - 1];
        }
    }
}
