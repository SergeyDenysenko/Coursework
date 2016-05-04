using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeographicalHandbook
{
    class Mainland : TerritoryObject
    {
        List<Country> countries;
        public Mainland(string mainlandName, int pop, double ar)
            : base(mainlandName, pop, ar)
        {
            countries = new List<Country>();
        }
        
    }
}
