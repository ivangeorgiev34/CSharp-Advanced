using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            List<Trainer> trainers = new List<Trainer>();
            while (command != "Tournament")
            {
                string[] tokens = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string trainerName = tokens[0];
                string pokemonName = tokens[1];
                string pokemonElement = tokens[2];
                int pokemonHealth = int.Parse(tokens[3]);
                bool flag = true;
                for (int i = 0; i < trainers.Count; i++) // peter george peter
                {
                    if (trainers[i].Name == trainerName)
                    {
                        flag = false;
                        Pokemon pokemon = new Pokemon() { PokemonName = pokemonName, Element = pokemonElement, Health = pokemonHealth };
                        trainers[i].CollectionOfPokemons.Add(pokemon);
                        break;
                    }
                }
                if (flag)
                {
                    Trainer trainer = new Trainer(trainerName, pokemonName, pokemonElement, pokemonHealth);
                    trainers.Add(trainer);
                }
                command = Console.ReadLine();
            }
            string element = Console.ReadLine();
            while (element != "End")
            {
                foreach (Trainer trainer in trainers)
                {
                    bool hasPokemonOfTheElement = true;
                    foreach (var pokemon in trainer.CollectionOfPokemons)
                    {
                        if (pokemon.Element == element)
                        {
                            trainer.Badges++;
                            hasPokemonOfTheElement = false;
                            break;
                        }
                    }
                    if (hasPokemonOfTheElement)
                    {
                        for (int i = 0; i < trainer.CollectionOfPokemons.Count; i++)
                        {
                            trainer.CollectionOfPokemons[i].Health = trainer.CollectionOfPokemons[i].Health - 10;
                            if (trainer.CollectionOfPokemons[i].Health <= 0)
                            {
                                trainer.CollectionOfPokemons.Remove(trainer.CollectionOfPokemons[i]);
                                i++;
                            }
                        }
                    }
                }
                element = Console.ReadLine();
            }

             // peter george josh
            foreach (Trainer trainer in trainers.OrderByDescending(x => x.Badges))
            {
                Console.WriteLine($"{ trainer.Name} {trainer.Badges} {trainer.CollectionOfPokemons.Count}");
            }
        }
    }
}
