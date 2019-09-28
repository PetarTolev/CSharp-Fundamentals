namespace P04_Online_Radio_Database.Exceptions
{
    class InvalidSongNameException : InvalidSongException
    {
        public InvalidSongNameException(string message = "Song name should be between 3 and 30 symbols.")
            : base(message)
        {
        }
    }
}