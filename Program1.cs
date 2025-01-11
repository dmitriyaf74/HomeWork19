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
        enum EqualType { NotEquals, Equals, Thesame }

        private static List<string> EqualTypeStr = ["Не совпадает","Совпадает","Одно и то же"];

        private static void ShowPlanet(string planetname, int planetnum, int aequator, EqualType venusEqv)
        {
            Console.WriteLine(planetname);
            Console.WriteLine($"Порядковый номер от солнца: {planetnum}");
            Console.WriteLine($"Длина экватора: {aequator} км");
            Console.WriteLine($"Эквивалент Венеры: {EqualTypeStr[(int)venusEqv]}");
            Console.WriteLine("");
        }

        private static EqualType GetEqualType(object obj1, object obj2)
        {
            if (obj1 == obj2) return EqualType.Thesame;
            if (obj1.Equals(obj2)) return EqualType.Equals;
            return EqualType.NotEquals;
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
            ShowPlanet(planeta.Name, planeta.Numerus, planeta.Aequator, GetEqualType(planeta, Venus));
            planeta = Terra;
            ShowPlanet(planeta.Name, planeta.Numerus, planeta.Aequator, GetEqualType(planeta, Venus));
            planeta = Mars;
            ShowPlanet(planeta.Name, planeta.Numerus, planeta.Aequator, GetEqualType(planeta, Venus));
            planeta = Venus2;
            ShowPlanet(planeta.Name, planeta.Numerus, planeta.Aequator, GetEqualType(planeta, Venus));
        }
    }
}
