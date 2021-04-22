using System;
using System.Collections.Generic;

namespace Pokedex
{
    class programm 
    {
        static void Main(string[] args)
        {
            Pokemon pokemon1 = new Pokemon();
            pokemon1.Name = "Derrling";
            pokemon1.Id = 585;
            pokemon1.Presentacion();

            Pokemon pokemon2 = new Pokemon();
            pokemon2.Name = "Poliwag";
            pokemon2.Id = 60;
            pokemon2.Presentacion();

            Pokemon pokemon3 = new Pokemon();
            pokemon3.Name = "Slakoth";
            pokemon3.Id = 287;
            pokemon3.Presentacion();

            Pokemon pokemon4 = new Pokemon();
            pokemon4.Name = "Snom";
            pokemon4.Id = 872;
            pokemon4.Presentacion();

            Pokemon pokemon5 = new Pokemon();
            pokemon5.Name = "Squirtle";
            pokemon5.Id= 7;
            pokemon5.Presentacion();

            Pokemon pokemon6 = new Pokemon();
            pokemon6.Name = "Togedemaru";
            pokemon6.Id = 777;
            pokemon6.Presentacion();

            Pokemon pokemon7= new Pokemon();
            pokemon7.Name = "Weedle";
            pokemon7.Id = 13;
            pokemon7.Presentacion();

            Pokemon pokemon8 = new Pokemon();
            pokemon8.Name = "Gossifleur";
            pokemon8.Id= 829;
            pokemon8.Presentacion();

            Pokemon pokemon9 = new Pokemon ();
            pokemon9.Name = "Piplup";
            pokemon9.Id= 393;
            pokemon9.Presentacion();

            Pokemon pokemon10 = new Pokemon();
            pokemon10.Name = "Butterfree";
            pokemon10.Id = 12;
            pokemon10.Presentacion();

            //lista de pokemones

            
            HashSet<Party> listaDePokemonesSet = new HashSet<Party>();
            listaDePokemonesSet.Add(new Party("Togedemaru", 777, false));
            listaDePokemonesSet.Add(new Party("Weedle", 13, true));
            listaDePokemonesSet.Add(new Party("Weedle", 13, true));
            listaDePokemonesSet.Add(new Party("Gossifleur",829, true ));
            listaDePokemonesSet.Add(new Party("Hattrem", 857, true));
            listaDePokemonesSet.Add(new Party("Snom", 872, false));

            Console.WriteLine(listaDePokemonesSet);



            

            

            






            
        }
    }
}
