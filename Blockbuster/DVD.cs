using System;
using System.Collections.Generic;
using System.Threading;

namespace Blockbuster
{
    class DVD : Movie
    {
        public DVD(string title, Genre category, int runtime, List<string> scenes) : base(title, category, runtime, scenes)
        {

        }

        public override void Play()
        {
            Console.WriteLine($"Which Scene of the DVD {Title}");
            Console.Write($"would you like to watch 0-{Scenes.Count - 1}: ");

            int selection = -1;
            while(!int.TryParse(Console.ReadLine(), out selection))
            {
                Console.WriteLine("ah ah ah, you didn't say the magic word");
            }

            Console.WriteLine();
            Console.WriteLine(Scenes[selection]);
        }

        public override void PrintInfo()
        {
            base.PrintInfo();
        }

        public override void PlayWholeMovie()
        {
            foreach(string scene in Scenes)
            {
                Console.WriteLine();
                Console.WriteLine(scene);

                Thread.Sleep(2000);
            }
        }
    }
}
