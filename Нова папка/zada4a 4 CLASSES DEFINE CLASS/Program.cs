using System;
using System.Linq;
using System.Globalization;
using System.Collections.Generic;

namespace zada4a_4_CLASSES_DEFINE_CLASS
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfSong = int.Parse(Console.ReadLine());
            List<song> songs = new List<song>();

            for (int i = 0; i < numberOfSong; i++)
            {
                var listOfProperties = Console.ReadLine().Split("_");
                string typeOfSong = listOfProperties[0];
                string nameOfSong = listOfProperties[1];
                string lenghtOfSong = listOfProperties[2];

                song song = new song();
                song.TypeList = typeOfSong;
                song.Name = nameOfSong;
                song.Time = lenghtOfSong;

                songs.Add(song);

            }
            
            string typeListToListnen = Console.ReadLine();

            List<song> filteredSongs = songs.Where(x => x.TypeList == typeListToListnen).ToList();
            if (typeListToListnen == "all")
            {
                foreach (var song in songs)
                {
                    Console.WriteLine(song.Name);
                }
            }
            else
            {
                foreach (var song in songs)
                {
                    if (song.TypeList == typeListToListnen)
                    {
                        Console.WriteLine(song.Name);
                    }
                }
            }
        }
    }
    class song
    {
        public string TypeList { get; set; }

        public string Name { get; set; }

        public string Time { get; set; }

    }
}
