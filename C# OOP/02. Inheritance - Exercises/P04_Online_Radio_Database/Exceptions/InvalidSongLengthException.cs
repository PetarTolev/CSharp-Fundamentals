namespace P04_Online_Radio_Database.Exceptions
{
    class InvalidSongLengthException : InvalidSongException
    {
        public InvalidSongLengthException(string message = "Invalid song length.")
            : base(message)
        {
        }
    }
}