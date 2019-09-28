namespace P04_Online_Radio_Database.Exceptions
{
    class InvalidArtistNameException : InvalidSongException
    {
        public InvalidArtistNameException(string message = "Artist name should be between 3 and 20 symbols.") 
            : base(message)
        {
        }
    }
}