using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using HomeWork19.Classes;

namespace HomeWork19
{
    static class Program1
    {
        private static void ShowPlanet(string planetname, int planetnum, int aequator, bool venusEqv)
        {
            Console.WriteLine(planetname);
            Console.WriteLine($"Порядковый номер от солнца: {planetnum}");
            Console.WriteLine($"Длина экватора: {aequator} км");
            Console.WriteLine($"Эквивалент Венеры: {venusEqv}");
            Console.WriteLine("");
        }

        public static void Execute()
        {
            var Venus = new
            {
                Name = "Венера",
                Numerus = 2,
                Aequator = 38025,
                Prior = (Object)null,
            };
            var Terra = new
            {
                Name = "Земля",
                Numerus = 3,
                Aequator = 40075,
                Prior = (Object)Venus,
            };
            var Mars = new
            {
                Name = "Марс",
                Numerus = 4,
                Aequator = 21344,
                Prior = (Object)Terra,
            };

            var Venus2 = Venus with {};

            dynamic planeta = Venus;
            ShowPlanet(planeta.Name, planeta.Numerus, planeta.Aequator, planeta.Equals(Venus));
            planeta = Terra;
            ShowPlanet(planeta.Name, planeta.Numerus, planeta.Aequator, planeta.Equals(Venus));
            planeta = Mars;
            ShowPlanet(planeta.Name, planeta.Numerus, planeta.Aequator, planeta.Equals(Venus));
            planeta = Venus2;
            ShowPlanet(planeta.Name, planeta.Numerus, planeta.Aequator, planeta.Equals(Venus));
        }
    }
}
