using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeWork19.Classes;

namespace HomeWork19
{
    internal class Program3
    {
        static int queryCounter = 0;

        private static string DPlanetValidator(string planetName)
        {
            queryCounter++;
            if (queryCounter % 3 == 0)
            {
                return "Вы спрашиваете слишком часто";
            }
            return null;
        }

        private static void ShowPlanetInfo(CatalogOfPlanet2 catalogOfPlanet2, string planetName)
        {
            int numerus;
            int aequator;
            string errstr;
            (numerus, aequator, errstr) = catalogOfPlanet2.GetPlanet(planetName, DPlanetValidator);
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

        private static void ShowPlanetInfoLambda(CatalogOfPlanet2 catalogOfPlanet2, string planetName)
        {
            int numerus;
            int aequator;
            string errstr;
            (numerus, aequator, errstr) = catalogOfPlanet2.GetPlanet(planetName,
                planetName => { queryCounter++; if (queryCounter % 3 == 0) return "Вы спрашиваете слишком часто!"; return null; }
                );
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

        private static void ShowPlanetInfoLambdaLemon(CatalogOfPlanet2 catalogOfPlanet2, string planetName)
        {
            int numerus;
            int aequator;
            string errstr;
            (numerus, aequator, errstr) = catalogOfPlanet2.GetPlanet(planetName,
                planetName => { if (planetName == "Лимония") return "Это запретная планета"; return null; }
                );
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
            var catalogOfPlanet2 = new CatalogOfPlanet2()
            {
                new Planeta(){ Name = "Венера", Numerus = 2, Aequator = 38025, Prior = null },
                new Planeta(){ Name = "Земля" , Numerus = 3, Aequator = 40075, Prior = null },
                new Planeta(){ Name = "Марс"  , Numerus = 4, Aequator = 21344, Prior = null },
            };
            for (int i = 0; i < catalogOfPlanet2.Count - 1; i++)
            {
                catalogOfPlanet2[i + 1].Prior = catalogOfPlanet2[i];
            }

            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("С делегатом");
            Console.ResetColor();
            Console.WriteLine("");
            ShowPlanetInfo(catalogOfPlanet2, "Земля");
            ShowPlanetInfo(catalogOfPlanet2, "Лимония");
            ShowPlanetInfo(catalogOfPlanet2, "Марс");

            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("С лямбдой");
            Console.ResetColor();
            Console.WriteLine("");
            ShowPlanetInfoLambda(catalogOfPlanet2, "Земля");
            ShowPlanetInfoLambda(catalogOfPlanet2, "Лимония");
            ShowPlanetInfoLambda(catalogOfPlanet2, "Марс");

            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("С лямбдой Лимония");
            Console.ResetColor();
            Console.WriteLine("");
            ShowPlanetInfoLambdaLemon(catalogOfPlanet2, "Земля");
            ShowPlanetInfoLambdaLemon(catalogOfPlanet2, "Лимония");
            ShowPlanetInfoLambdaLemon(catalogOfPlanet2, "Марс");

        }

    }
}
