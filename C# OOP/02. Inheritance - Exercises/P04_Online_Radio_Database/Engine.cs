namespace P04_Online_Radio_Database
{
    using Exceptions;
    using System;
    using System.Linq;

    public class Engine
    {
        private readonly SongsCatalog songsCatalog;
        
        public Engine()
        {
            this.songsCatalog = new SongsCatalog();
        }

        public void Run()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine()
                    .Split(';');

                var artistName = input[0];
                var songName = input[1];
                var songLengthProps = input[2]
                    .Split(':')
                    .ToArray();
                try
                {
                    if (!int.TryParse(songLengthProps[0], out int minutes) ||
                        !int.TryParse(songLengthProps[1], out int seconds))
                    {
                        throw new InvalidSongLengthException();
                    }

                    SongLength songLength = new SongLength(minutes, seconds);

                    Song song = new Song(artistName, songName, songLength);

                    this.songsCatalog.AddSong(song);
                    Console.WriteLine("Song added.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            PrintResult();
        }

        private void PrintResult()
        {
            Console.WriteLine($"Songs added: {this.songsCatalog.Count}");

            Console.WriteLine($"Playlist length: {this.songsCatalog.CalculateTotalTime()}");
        }
    }
}