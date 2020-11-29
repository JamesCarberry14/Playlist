using System;
using System.Collections.Generic;
using System.Text;

namespace Playlist
{
    public class Song : IComparable
    {
        public string Title { get; set; }
        public string Artist { get; set; }
        public double Duration { get; set; }


        public Genre MusicGenre { get; set; }


        public Song(string title, string artist, double duration, Genre musicGenre )
        {
            Title = title;
            Artist = artist;
            Duration = duration;
            MusicGenre = musicGenre;
        }

        public Song(string title, string artist) : this(title, artist, 0, Genre.Other) { }


        public Song() : this("Unknown", "Unknown") { }



        public override string ToString()
        {
            return string.Format($"{Title} {Artist} {Duration} {MusicGenre}");
        }

        public int CompareTo(object obj)
        {
            Song that = (Song)obj;

            int returnValue = this.Artist.CompareTo(that.Artist);

            if (returnValue == 0)
            {
                returnValue = this.Title.CompareTo(that.Title);
            }

            return returnValue;
        }
    }

    public enum Genre {Rock, Pop, Dance, Other }
}
