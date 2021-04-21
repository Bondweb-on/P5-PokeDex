using System;
using System.Collections.Generic;

namespace P5_PokeDex
{
    class Pokedex
    {
        public List<PokemonRegistrado> pokemon;

        public Pokedex()
        {
            pokemon = new List<PokemonRegistrado>();
        }

        public PokemonRegistrado ConsultarPokemonPorId(int id)
        {
            for (int i = 0; i < pokemon.Count; i++)
            {
                Console.WriteLine("Buscando pokemon...");
                if (pokemon[i].id == id)
                {
                    return pokemon[i];
                }
            }

            return null;

        }

        public void ConsultarYMostrarPorId(int id)
        {
            bool resultadoEncontrado = false;
            for (int i = 0; i < pokemon.Count; i++)
            {
                Console.WriteLine("Buscando pokemon...");
                if (pokemon[i].id == id)
                {
                    Console.WriteLine("Resultado encontrado: " + pokemon[i].nombre);
                    resultadoEncontrado = true;
                    break;
                }
            }

            if (!resultadoEncontrado)
            {
                Console.WriteLine("No se encontró un resultado");
            }
        }


        public List<PokemonRegistrado> ConsultarTodos()
        {
            return this.pokemon;
        }

        public void ConsultarYMostrarTodos()
        {

        }
    }
}