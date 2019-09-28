namespace P04_Online_Radio_Database.Exceptions
{
    class InvalidSongMinutesException : InvalidSongLengthException
    {
        public InvalidSongMinutesException(string message = "Song minutes should be between 0 and 14.")
            : base(message)
        { 
        }
    }
}