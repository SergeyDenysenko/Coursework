using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeographicalHandbook.Classes
{
    public class Country : TerritoryObject
    {
        public Country(string name, string capital, long population, double area)
            : base(name, capital, population, area)
        {

        }
        public override int TypeOF { 
            get 
            { 
                return 2; 
            } 
        }
    }
}
