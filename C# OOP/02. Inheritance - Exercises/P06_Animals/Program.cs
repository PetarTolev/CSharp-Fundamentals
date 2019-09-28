namespace P06_Animals
{
    using System;

    public class Program
    {
        public static void Main()
        {
            while (true)
            {
                var type = Console.ReadLine();
                if (type == "Beast!")
                {
                    break;
                }

                var props = Console.ReadLine().Split();
                var name = props[0];
                var age = int.Parse(props[1]);
                var gender = props[2];

                try
                {
                    if (type == "Dog")
                    {
                        Dog dog = new Dog(name, age, gender);

                        Console.WriteLine(dog);
                    }
                    else if (type == "Cat")
                    {
                        Cat cat = new Cat(name, age, gender);

                        Console.WriteLine(cat);
                    }
                    else if (type == "Frog")
                    {
                        Frog frog = new Frog(name, age, gender);

                        Console.WriteLine(frog);
                    }
                    else if (type == "Kitten")
                    {
                        Kitten kitten = new Kitten(name, age, "Female");

                        Console.WriteLine(kitten);
                    }
                    else if (type == "Tomcat")
                    {
                        Tomcat tomcat = new Tomcat(name, age, "Male");

                        Console.WriteLine(tomcat);
                    }
                    else
                    {
                        throw new ArgumentException("Invalid input!");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
