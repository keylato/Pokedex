using System;
using System.Collections.Generic;

namespace Pokedex
{
    class Party
    {
        public string name;
        public int id;

        public bool female;

        public string NamePokemon
        {
            get => name;
        }

        public Party(string name, int id, bool female)
        {
            this.name = name;
            this.id = id;
            this.female = female;
        }

    }
}