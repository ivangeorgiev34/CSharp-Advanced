using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Trainer
    {
        public Trainer(string pokemonName, string pokemonElement, int pokemonHealth)
        {
            CollectionOfPokemons.Add(new Pokemon { PokemonName = pokemonName, Element = pokemonElement, Health = pokemonHealth });
        }
        public Trainer(string trainerName, string pokemonName, string pokemonElement, int pokemonHealth)
        {
            Name = trainerName;
            if (CollectionOfPokemons == null)
            {
                CollectionOfPokemons = new List<Pokemon>();
               
            }
            CollectionOfPokemons.Add(new Pokemon { PokemonName = pokemonName, Element = pokemonElement, Health = pokemonHealth });
        }
        public string Name { get; set; }
        public int Badges { get; set; }
        public List<Pokemon> CollectionOfPokemons { get; set ; }

    }
}
