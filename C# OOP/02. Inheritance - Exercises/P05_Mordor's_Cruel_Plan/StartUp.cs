namespace P05_Mordor_s_Cruel_Plan
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var inputFoods = Console.ReadLine().Split().Select(x => x.ToLower()).ToList();

            int gandalfHappines = 0;

            foreach (var food in inputFoods)
            {
                switch (food)
                {
                    case "cram":
                        gandalfHappines += 2;
                        break;
                    case "lembas":
                        gandalfHappines += 3;
                        break;
                    case "apple":
                        gandalfHappines += 1;
                        break;
                    case "melon":
                        gandalfHappines += 1;
                        break;
                    case "honeycake":
                        gandalfHappines += 5;
                        break;
                    case "mushrooms":
                        gandalfHappines -= 10;
                        break;
                    default:
                        gandalfHappines -= 1;
                        break;
                }
            }

            string mood = null;

            if (gandalfHappines < -5)
            {
                mood = "Angry";
            }
            else if (gandalfHappines >= -5 && gandalfHappines <= 0)
            {
                mood = "Sad";
            }
            else if (gandalfHappines >= 0 && gandalfHappines <= 15)
            {
                mood = "Happy";
            }
            else if (gandalfHappines > 15)
            {
                mood = "JavaScript";
            }

            Console.WriteLine(gandalfHappines);
            Console.WriteLine(mood);
        }
    }
}