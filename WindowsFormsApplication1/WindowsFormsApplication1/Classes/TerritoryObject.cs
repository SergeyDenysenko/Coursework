using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeographicalHandbook
{
    abstract class TerritoryObject
    {
        
        protected string name;
        protected int population;
        protected double area;

        public TerritoryObject(string objName, int pop, double ar)
        {
            this.name = objName;
            this.population = pop;
            this.area = ar;
        }
        public string Name { get { return name; } }

        public int Population { get { return population; } }

        public double Area { get { return area; } }
        
    }
}
