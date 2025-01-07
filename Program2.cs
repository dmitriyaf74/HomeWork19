using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using HomeWork19.Classes;

namespace HomeWork19
{
    internal class Program2
    {
        private static void ShowPlanetInfo(CatalogOfPlanet catalogOfPlanet, string planetName)
        {
            int numerus;
            int aequator;
            string errstr;
            (numerus, aequator, errstr) = catalogOfPlanet.GetPlanet(planetName);
            Console.WriteLine(planetName);
            if (aequator == 0)
            {
                Console.WriteLine(errstr);
            }
            else
            {
                Console.WriteLine($"Порядковый номер от солнца: {numerus}");
                Console.WriteLine($"Длина экватора: {aequator} км");
            }
            Console.WriteLine("");
        }

        public static void Execute()
        {
            var catalogOfPlanet = new CatalogOfPlanet()
            {
                new Planeta(){ Name = "Венера", Numerus = 2, Aequator = 38025, Prior = null },
                new Planeta(){ Name = "Земля" , Numerus = 3, Aequator = 40075, Prior = null },
                new Planeta(){ Name = "Марс"  , Numerus = 4, Aequator = 21344, Prior = null },
            };
            for (int i = 0; i < catalogOfPlanet.Count - 1; i++)
            {
                catalogOfPlanet[i + 1].Prior = catalogOfPlanet[i];
            }

            ShowPlanetInfo(catalogOfPlanet, "Земля");
            ShowPlanetInfo(catalogOfPlanet, "Лимония");
            ShowPlanetInfo(catalogOfPlanet, "Марс");

        }

    }
}
