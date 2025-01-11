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
            if (!string.IsNullOrEmpty(errstr))
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
            var catalogOfPlanet = new CatalogOfPlanet();

            ShowPlanetInfo(catalogOfPlanet, "Земля"  );
            ShowPlanetInfo(catalogOfPlanet, "Лимония");
            ShowPlanetInfo(catalogOfPlanet, "Марс"   );

        }

    }
}
