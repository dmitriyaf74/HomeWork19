using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeWork19.Classes;
using static HomeWork19.Classes.CatalogOfPlanet2;

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

        private static void ShowPlanetInfoLambda(CatalogOfPlanet2 catalogOfPlanet2, string planetName)
        {
            int numerus;
            int aequator;
            string errstr;
            (numerus, aequator, errstr) = catalogOfPlanet2.GetPlanet(planetName,
                planetName => { queryCounter++; if (queryCounter % 3 == 0) return "Вы спрашиваете слишком часто!"; return null; }
                );
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

        private static void ShowPlanetInfoLambdaLemon(CatalogOfPlanet2 catalogOfPlanet2, string planetName)
        {
            int numerus;
            int aequator;
            string errstr;
            (numerus, aequator, errstr) = catalogOfPlanet2.GetPlanet(planetName,
                planetName => { if (planetName == "Лимония") return "Это запретная планета"; return null; }
                );
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

        private static void WriteSectorTitle(string title)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write(title);
            Console.ResetColor();
            Console.WriteLine("");
        }

        public delegate void DShowPlanetInfo(CatalogOfPlanet2 catalogOfPlanet2, string planetname);
        private static void ShowPlanetInfoCustom(CatalogOfPlanet2 catalogOfPlanet2, DShowPlanetInfo showPlanetInfo)
        {
            showPlanetInfo(catalogOfPlanet2, "Земля");
            showPlanetInfo(catalogOfPlanet2, "Лимония");
            showPlanetInfo(catalogOfPlanet2, "Марс");
        }

        public static void Execute()
        {
            var catalogOfPlanet2 = new CatalogOfPlanet2();

            WriteSectorTitle("С делегатом");
            ShowPlanetInfoCustom(catalogOfPlanet2, ShowPlanetInfo);
            WriteSectorTitle("С лямбдой");
            ShowPlanetInfoCustom(catalogOfPlanet2, ShowPlanetInfoLambda);
            WriteSectorTitle("С лямбдой Лимония");
            ShowPlanetInfoCustom(catalogOfPlanet2, ShowPlanetInfoLambdaLemon);
        }

    }
}
