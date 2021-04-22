using System;

namespace Pokedex
{
    public class Pokemon
    {
        public string Name;
        public int Id;

        public string NombrePokemon;

        public string nombrePokemon
        {
            get => "name" + this.Name;

            set => this.Name = value;
        }

        public int IdPokemnon;

        public int idPokemon
        {
            get => Id + this.idPokemon;

            set => this.idPokemon = value;
        }
        
        public Pokemon(string name, int Id)
        {
            this.Name = name;

            this.Id = Id;
        }

        public Pokemon()
        {
        }

        public void Presentacion ()
        {
            Console.WriteLine(Name + " " + Id);
        }

    }


}
