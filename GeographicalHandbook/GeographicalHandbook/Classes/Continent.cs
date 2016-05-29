using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeographicalHandbook.Classes
{
    public class Continent : TerritoryObject
    {
        public Continent(string name, long population, double area)
            : base(name, population, area)
        {

        }
        public override int TypeOF
        {
            get
            {
                return 1;
            }
        }
        public override string Capital
        {
            get
            {
                return string.Empty;
            }
        }
    }
}
