namespace P04_Telephony
{
    using System;
    using System.Linq;

    public class SmartPhone : ICallable, IBrowsable
    {
        public SmartPhone()
        {
        }

        public string Call(string phoneNumber)
        {
            if (phoneNumber.Any(x => char.IsLetter(x)))
            {
                throw new ArgumentException("Invalid number!");
            }

            return $"Calling... {phoneNumber}";
        }

        public string Browse(string website)
        {
            if (website.Any(x => char.IsDigit(x)))
            {
                throw new ArgumentException("Invalid URL!");
            }

            return $"Browsing: {website}!";
        }
    }
}
