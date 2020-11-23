using System;
using System.Collections.Generic;

namespace ProgrammingPractiseQuestion
{
    class Program
    {
        static void Main(string[] args)
        {
            Song s1 = new Song("BEAUTIFUL PEOPLE", "ED SHEERAN", 3.15, Genre.Pop);
            Song s2 = new Song("DANCE MONKEY", "TONES & I", 4.20, Genre.Dance);
            Song s3 = new Song("CIRCLES", "POST MALONE", 3.25, Genre.Pop);
            Song s4 = new Song("RIDE IT", "REGARD", 3.37, Genre.Dance);
            Song s5 = new Song("SOUTH OF THE BORDER", "ED SHEERAN", 4.26, Genre.Pop);

            List<Song> playlist = new List<Song>();
            playlist.Add(s1);
            playlist.Add(s2);
            playlist.Add(s3);
            playlist.Add(s4);
            playlist.Add(s5);

            foreach(Song song in playlist)
            {
                Console.WriteLine(song);
            }
        }
    }
}
