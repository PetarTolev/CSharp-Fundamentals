namespace P11_Pokemon_Trainer
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            List<Trainer> trainers = new List<Trainer>();

            while (true)
            {
                string inputLine = Console.ReadLine();

                if (inputLine == "Tournament")
                {
                    break;
                }

                string[] splitedInputLine = inputLine.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string trainerName = splitedInputLine[0];
                string pokemonName = splitedInputLine[1];
                string pokemonElement = splitedInputLine[2];
                int pokemonHealth = int.Parse(splitedInputLine[3]);

                Pokemon pokemon = new Pokemon(pokemonName, pokemonElement, pokemonHealth);

                Trainer trainer = trainers.FirstOrDefault(x => x.Name == trainerName);

                if (trainer == null)
                {
                    trainer = new Trainer(trainerName);
                    trainers.Add(trainer);
                }

                trainer.Pokemons.Add(pokemon);
            }

            while (true)
            {
                string inputCommand = Console.ReadLine().TrimEnd();

                if (inputCommand == "End")
                {
                    break;
                }

                foreach (var trainer in trainers)
                {
                    if (trainer.Pokemons.Any(x => x.Element == inputCommand))
                    {
                        trainer.NumberOfBadges++;
                    }
                    else
                    {
                        ReduceHealth(trainer);
                    }
                }
            }

            Console.WriteLine(string.Join(Environment.NewLine, trainers.OrderByDescending(x => x.NumberOfBadges)));
        }

        public static void ReduceHealth(Trainer trainer)
        {
            for (int i = 0; i < trainer.Pokemons.Count; i++)
            {
                Pokemon pokemon = trainer.Pokemons[i];

                pokemon.Health -= 10;

                RemoveDeadPokemons(pokemon, trainer);
            }
        }

        public static void RemoveDeadPokemons(Pokemon pokemon, Trainer trainer)
        {
            if (pokemon.Health <= 0)
            {
                trainer.Pokemons.Remove(pokemon);
            }
        }
    }
}
