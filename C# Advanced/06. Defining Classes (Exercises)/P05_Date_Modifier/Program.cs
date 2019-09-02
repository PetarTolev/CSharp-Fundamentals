namespace P05_Date_Modifier
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            DateTime firstDateInput = DateTime.Parse(Console.ReadLine());
            DateTime secondDateInput = DateTime.Parse(Console.ReadLine());

            DateModifier dateModifier = new DateModifier(firstDateInput, secondDateInput);

            Console.WriteLine(dateModifier.CalculateDifference());
        }
    }
}
