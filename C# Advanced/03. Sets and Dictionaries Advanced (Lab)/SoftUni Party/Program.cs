namespace SoftUni_Party
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> VIP = new HashSet<string>();
            HashSet<string> regular = new HashSet<string>();

            while (true)
            {
                string beforeParty = Console.ReadLine();

                if (beforeParty == "PARTY")
                {
                    break;
                }

                if (char.IsDigit(beforeParty[0]))
                {
                    VIP.Add(beforeParty);
                }
                else
                {
                    regular.Add(beforeParty);
                }
            }

            while (true)
            {
                string afterParty = Console.ReadLine();

                if (afterParty == "END")
                {
                    break;
                }

                if (char.IsDigit(afterParty[0]))
                {
                    VIP.Remove(afterParty);
                }
                else
                {
                    regular.Remove(afterParty);
                }
            }

            Console.WriteLine(VIP.Count + regular.Count);

            if (VIP.Any())
            {
                Console.WriteLine(string.Join(Environment.NewLine, VIP));
            }

            if (regular.Any())
            {
                Console.WriteLine(string.Join(Environment.NewLine, regular));
            }
        }
    }
}
