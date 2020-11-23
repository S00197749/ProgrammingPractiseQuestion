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
    }
    public enum Genre { Rock, Pop, Dance, Other}
}
