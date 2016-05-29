using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeographicalHandbook.Classes
{
    public class City : TerritoryObject
    {
        public City(string nam, long pop, double ar)
        {
            base.Name = nam;
            base.Population = pop;
            base.Area = ar;
        }
        public override int TypeOF
        {
            get
            {
                return 4;
            }
        }
        public override void AddChild(TerritoryObject current)
        {
            
        }
        public override string Capital
        {
            get
            {
                return string.Empty;
            }
        }
        public override int Length
        {
            get
            {
                return -1;
            }
        }
        public override TerritoryObject GetChildByName(string name)
        {
            return null;
        }
        public override double UrbanPopulation()
        {
            return 1;
        }
         
    }
}
