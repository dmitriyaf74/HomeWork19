using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork19.Classes
{
    internal class CatalogOfPlanet : List<Planeta>
    {
        int queryCounter = 0;
        public (int numerus, int aequator, string errstr) GetPlanet(string planetname) //Tuple<string, int, string>
        {
            queryCounter++;
            if (queryCounter % 3 == 0)
            {
                return (0, 0, "Вы спрашиваете слишком часто");
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
