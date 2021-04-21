using System;
using System.Collections.Generic;

namespace P5_PokeDex
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pokémon: Chafa Versión");
            
            Pokedex pokedex = new Pokedex();


            pokedex.pokemon.Add(new PokemonRegistrado("Vulpix", 37));
            pokedex.pokemon.Add(new PokemonRegistrado("Ninetales", 38));
            pokedex.pokemon.Add(new PokemonRegistrado("Charmander", 4));
            pokedex.pokemon.Add(new PokemonRegistrado("Charmeleon", 5));
            pokedex.pokemon.Add(new PokemonRegistrado("Charizard", 6));
            pokedex.pokemon.Add(new PokemonRegistrado("Growlithe", 58));
            pokedex.pokemon.Add(new PokemonRegistrado("Arcanine", 59));
            pokedex.pokemon.Add(new PokemonRegistrado("Jolteon", 135));
            pokedex.pokemon.Add(new PokemonRegistrado("Mewtwo", 150));
            pokedex.pokemon.Add(new PokemonRegistrado("Butterfree", 12));


            PokemonRegistrado resultadoBusquedaPorId = pokedex.ConsultarPokemonPorId(3);
            Console.WriteLine("Resultado de la búsqueda: " + resultadoBusquedaPorId.nombre);
            Console.WriteLine("------------------");
            pokedex.ConsultarYMostrarPorId(3);

            //party 

            List<PokemonParty> pokemonParty = new List<PokemonParty>();

            pokemonParty.Add(new PokemonParty("Charizard", 6, "Masculino"));
            pokemonParty.Add(new PokemonParty("Arcanine", 59, "Masculino"));
            pokemonParty.Add(new PokemonParty("Butterfree", 12, "Femenino"));
            pokemonParty.Add(new PokemonParty("Mewtwo", 150, "Indefinido"));
            pokemonParty.Add(new PokemonParty("Jolteon", 135, "Masculino"));
            pokemonParty.Add(new PokemonParty("Ninetales", 38, "Femenino"));
        }
    }
}
