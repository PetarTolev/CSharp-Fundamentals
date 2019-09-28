namespace P04_Online_Radio_Database
{
    using Exceptions;

    public class Song
    {
        private string artistName;
        private string songName;

        public Song(string artistName, string songName, SongLength songLength)
        {
            this.ArtistName = artistName;
            this.SongName = songName;
            this.SongLength = songLength;
        }

        public string ArtistName
        {
            get => this.artistName;

            private set
            {
                if (value.Length < 3 || value.Length > 20)
                {
                    throw new InvalidArtistNameException();
                }

                this.artistName = value;
            }
        }

        public string SongName
        {
            get => this.songName;

            private set
            {
                if (value.Length < 3 || value.Length > 30)
                {
                    throw new InvalidSongNameException();
                }

                this.songName = value;
            }
        }

        public SongLength SongLength { get; }
    }
}