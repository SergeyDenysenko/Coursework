using GeographicalHandbook.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeographicalHandbook
{
    class Region : TerritoryObject
    {
        protected string mainCity;
        public List<City> cities;
        public Region(string objName, string mainC, int pop, double ar)
            : base(objName, pop, ar)
        {
            this.mainCity = mainC;
            cities = new List<City>();
        }
       
        public string MainCity { get { return mainCity; } }
       
        public string GetRegion()
        {
            return name;
        }
        public int numberOfCities()
        {
            return cities.Count;
        }
        public void AddCity(City cur)
        {
            cities.Add(cur);
        }
        
    }
}
