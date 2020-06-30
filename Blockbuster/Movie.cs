using System;
using System.Collections.Generic;
using System.Text;

namespace Blockbuster
{
    abstract class Movie
    {
        public string Title { get; set; }
        public Genre Category { get; set; }
        public int Runtime { get; set; }
        public List<string> Scenes { get; set; }

        public Movie()
        {

        }

        public Movie(string title, Genre category, int runtime, List<string> scenes)
        {
            Title = title;
            Category = category;
            Runtime = runtime;
            Scenes = scenes;
        }

        public virtual void PrintInfo()
        {
            Console.WriteLine();
            Console.WriteLine($"{Title}");
            Console.WriteLine($"Category: {Category}");
            Console.WriteLine($"RunTime: {Runtime} minutes");
        }

        public void PrintScenes()
        {
            for(int i = 0; i < Scenes.Count; i++)
            {
                Console.WriteLine($"{i}: {Scenes[i]}");
            }
        }

        public abstract void Play();
        public abstract void PlayWholeMovie();
    }
}
