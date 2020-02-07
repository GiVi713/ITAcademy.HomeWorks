using System;
using System.Collections.Generic;
using System.Text;

namespace Project_14._2
{
    class Song : ISong
    {
        
        public string songName { get; set; }
        public double songDuration { get; set; }
        public string songAuthor { get; set; }
        public int songYear { get; set; }

        public void NewSong()
        {
            Console.WriteLine("Укажите автора");
                songAuthor = Console.ReadLine();
            Console.WriteLine("Укажите название");
                songName = Console.ReadLine();
            Console.WriteLine("Укажите длительность");
                songDuration = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Укажите её год");
                songYear = Convert.ToInt32(Console.ReadLine());
        }

        public void GetSongData(Song song)
        {
            var anonSong = new { song.songName, song.songDuration, song.songYear };
            Console.WriteLine($"Песня {anonSong.songName} длительностью {anonSong.songDuration} минут была выпущена в {anonSong.songYear}");
        }
    }
}
