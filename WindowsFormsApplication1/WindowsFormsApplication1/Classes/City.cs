using GeographicalHandbook.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeographicalHandbook
{
    class City : TerritoryObject
    {

        public City(string objName, int pop, double ar) : base (objName, pop, ar)
        {

        }
    }
}
