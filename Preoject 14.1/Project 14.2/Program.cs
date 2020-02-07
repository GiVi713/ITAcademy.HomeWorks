using System;
using System.Collections.Generic;

namespace Project_14._2
{
    class Program
    {
        public static List<Song> allSongs = new List<Song> { };

        static void Main()
        {
            Song newSong = new Song();
            newSong.NewSong();
            newSong.GetSongData(newSong);
        }
    }
}
