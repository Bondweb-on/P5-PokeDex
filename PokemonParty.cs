using System;

namespace P5_PokeDex
{
    class PokemonParty
    {
        public string nombre;

        public int id;

        public string genero;

        public PokemonParty(string nombre, int id, string genero)
        {
            this.nombre = nombre;
            this.id = id;
            this.genero = genero;
        }

    }
}