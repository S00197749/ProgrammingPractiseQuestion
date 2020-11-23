using System;
using System.Collections.Generic;
using System.Text;

namespace ProgrammingPractiseQuestion
{
    class Song
    {
        #region Properties
        public string Title { get; set; }
        public string Artist { get; set; }
        public double Duration { get; set; }

        public Genre MusicGenre { get; set; }

        #endregion Properties

        #region Constructors
        public Song (string title, string artist, double duration, Genre musicgenre)
        {
            Title = title;
            Artist = artist;
            Duration = duration;
            MusicGenre = musicgenre;
        }
        public Song(string title, string artist):this(title, artist, 0, Genre.Other) { }

        public Song() : this("Unknown", "Unknown") { }

        #endregion Constructors

        public override string ToString()
        {
            return string.Format($"{Title} {Artist} {Duration} {MusicGenre}");
        }
    }
    public enum Genre { Rock, Pop, Dance, Other}
}
