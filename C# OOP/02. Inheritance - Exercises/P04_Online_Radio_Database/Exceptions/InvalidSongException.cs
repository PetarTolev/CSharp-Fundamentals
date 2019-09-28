namespace P04_Online_Radio_Database.Exceptions
{
    using System;

    class InvalidSongException : Exception
    {
        private string message;

        public InvalidSongException(string message = "Invalid song.")
            : base(message)
        {
        }
    }
}