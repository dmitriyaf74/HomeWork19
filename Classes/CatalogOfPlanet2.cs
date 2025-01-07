using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork19.Classes
{
    internal class CatalogOfPlanet2 : List<Planeta>
    {
        public delegate string DPlanetValidator(string planetname);


        int QueryCounter = 0;
        public (int numerus, int aequator, string errstr) GetPlanet(string planetname, DPlanetValidator PlanetValidator)
        {
            var errstr = PlanetValidator(planetname);
            if (errstr != "" && errstr != null)
            {
                return (0, 0, errstr);
            }
            foreach (var pl in this)
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
