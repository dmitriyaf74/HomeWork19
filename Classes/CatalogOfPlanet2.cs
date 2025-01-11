using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork19.Classes
{
    internal class CatalogOfPlanet2
    {
        public delegate string DPlanetValidator(string planetname);

        int QueryCounter = 0;
        private readonly List<Planeta> PlanetList;

        public CatalogOfPlanet2()
        {
            PlanetList = new List<Planeta>();
            Planeta planeta = new Planeta() { Name = "Венера", Numerus = 2, Aequator = 38025, Prior = null };
            PlanetList.Add(planeta);
            planeta = new Planeta() { Name = "Земля", Numerus = 3, Aequator = 40075, Prior = planeta };
            PlanetList.Add(planeta);
            planeta = new Planeta() { Name = "Марс", Numerus = 4, Aequator = 21344, Prior = planeta };
            PlanetList.Add(planeta);
        }

        public (int numerus, int aequator, string errstr) GetPlanet(string planetname, DPlanetValidator PlanetValidator)
        {
            var errstr = PlanetValidator(planetname);
            if (!string.IsNullOrEmpty(errstr))
            {
                return (0, 0, errstr);
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
