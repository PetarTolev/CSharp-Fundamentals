namespace P04_Online_Radio_Database
{
    using Exceptions;

    public class SongLength
    {
        private int minutes;

        private int seconds;

        public SongLength(int minutes, int seconds)
        {
            this.Minutes = minutes;
            this.Seconds = seconds;
        }

        public int Minutes
        {
            get => this.minutes;

            set
            {
                if (value < 0 || value > 14)
                {
                    throw new InvalidSongMinutesException();
                }

                this.minutes = value;
            }
        }

        public int Seconds
        {
            get => this.seconds;

            set
            {
                if (value < 0 || value > 59)
                {
                    throw new InvalidSongSecondsException();
                }

                this.seconds = value;
            }
        }
    }
}