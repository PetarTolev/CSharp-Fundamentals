namespace P04_Online_Radio_Database
{
    using System;
    using System.Collections.Generic;

    class SongsCatalog
    {
        private List<Song> songs;

        public SongsCatalog()
        {
            songs = new List<Song>();
        }

        public int Count => this.songs.Count;

        public void AddSong(Song song)
        {
            this.songs.Add(song);
        }

        public string CalculateTotalTime()
        {
            DateTime totalTime = new DateTime();

            foreach (var song in this.songs)
            {
                totalTime = totalTime.AddMinutes(song.SongLength.Minutes);
                totalTime = totalTime.AddSeconds(song.SongLength.Seconds);
            }
            return $"{totalTime.Hour}h {totalTime.Minute}m {totalTime.Second}s";
        }
    }
}