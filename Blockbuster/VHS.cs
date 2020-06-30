using System;
using System.Collections.Generic;
using System.Threading;

namespace Blockbuster
{
    class VHS : Movie
    {
        public int CurrentTime { get; set; } = 0;

        public VHS(string title, Genre category, int runtime, List<string> scenes) : base (title, category, runtime, scenes)
        {
        }

        public override void Play()
        {
            if(CurrentTime < Scenes.Count)
            {
                Console.WriteLine();
                Console.WriteLine(Scenes[CurrentTime]);
                Console.WriteLine();
                CurrentTime++;
            }
            else
            {
                Console.WriteLine("Sorry the movie has reached the end");
                Console.Write("Would you like to rewind the tape? ");

                if(Console.ReadLine().ToLower() == "y")
                {
                    Rewind();
                }
            }            
        }

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Current Runtime: {CurrentTime}");
            Console.WriteLine();
        }

        public void Rewind()
        {
            Console.Write("Would you like to Rewind the tape before returning? ");

            if (Console.ReadLine().ToLower() == "y")
            {
                Thread.Sleep(2000);
                CurrentTime = 0;
                Console.WriteLine("And done... Thanks for taking the time to be KIND and rewind!");
            }
            else
            {
                Console.WriteLine("That will be a fee of $2.00");
            }            
        }

        public override void PlayWholeMovie()
        {
            CurrentTime = 0;
            foreach(string scene in Scenes)
            {
                Console.WriteLine();
                Console.WriteLine(Scenes[CurrentTime]);
                Console.WriteLine();
                CurrentTime++;

                Thread.Sleep(2000);
            }
        }
    }
}
