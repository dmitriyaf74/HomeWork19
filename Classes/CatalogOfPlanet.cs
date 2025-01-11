using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork19.Classes
{
    internal class CatalogOfPlanet
    {
        private int QueryCounter = 0;
        private readonly List<Planeta> PlanetList;

        public CatalogOfPlanet() 
        {
            PlanetList = new List<Planeta>();
            Planeta planeta = new Planeta() { Name = "Венера", Numerus = 2, Aequator = 38025, Prior = null };
            PlanetList.Add(planeta);
            planeta = new Planeta() { Name = "Земля", Numerus = 3, Aequator = 40075, Prior = planeta };
            PlanetList.Add(planeta);
            planeta = new Planeta() { Name = "Марс", Numerus = 4, Aequator = 21344, Prior = planeta };
            PlanetList.Add(planeta);
        }

        public (int numerus, int aequator, string errstr) GetPlanet(string planetname) 
        {
            QueryCounter++;
            if (QueryCounter % 3 == 0)
            {
                return (0, 0, "Вы спрашиваете слишком часто");
            }
            foreach (var pl in this.PlanetList)
            {
                if (pl.Name == planetname)
                {
                    return (pl.Numerus, pl.Aequator, "");
                }
            };
            return (0, 0, "Не удалось найти планету");
        }
    }
}
