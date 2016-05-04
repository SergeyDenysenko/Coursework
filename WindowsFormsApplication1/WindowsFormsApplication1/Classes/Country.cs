using GeographicalHandbook.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeographicalHandbook
{
    class Country : TerritoryObject  
    {
        public List<Region> regions;
        protected string capital;
        public Country(string objName, string cap, int pop, double ar) :base (objName, pop, ar) 
        {
            this.capital = cap;
            this.regions = new List<Region>();
        }
        
        public string Capital { get { return capital;  } }
       
        public void AddRegion(Region current)
        {
            regions.Add(current);
        }
    }
}
