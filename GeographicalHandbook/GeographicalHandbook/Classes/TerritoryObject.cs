using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeographicalHandbook.Classes
{
    public class TerritoryObject
    {
        protected List<TerritoryObject> childObjects;
        public TerritoryObject(string name, string capital, long population, double area)
        {
            Name = name;
            Capital = capital;
            Population = population;
            Area = area;
            childObjects = new List<TerritoryObject>();
        }
        public TerritoryObject(string name, long population, double area)
        {
            Name = name;
            Population = population;
            Area = area;
            childObjects = new List<TerritoryObject>();
        }
        public virtual string Name
        {
            get;
            protected set;
        }
        public virtual long Population
        {
            get;
            protected set;
        }
        public virtual double Area
        {
            get;
            protected set;
        }
        public virtual string Capital
        {
            get;
            protected set;
        }
        public int AllChildLength
        {
            get
            {
                int result = 0;
                foreach (TerritoryObject cur in childObjects)
                    result += cur.Length;
                return result;
            }
        }
        public TerritoryObject()
        {
            childObjects = new List<TerritoryObject>();
        }
        public TerritoryObject this[int i]
        {
            get
            {
                if (i >= 0 && i < this.Length)
                    return childObjects[i];
                return null;
            }
        }
        public virtual void Search(string query, List<TerritoryObject> result)
        {
            if (query.Length != 0)
            {
                int queryLength = query.Length;
                foreach (TerritoryObject cur in childObjects)
                {
                    if (queryLength <= cur.Name.Length && cur.Name.Substring(0, queryLength).ToLower() == query.ToLower())
                        result.Add(cur);
                    cur.Search(query, result);
                }
            }
            
        }
        public virtual TerritoryObject SearchFullName(string query)
        {
            TerritoryObject result = null;
            if (query.Length > 1)
            {
                
                foreach (TerritoryObject cur in childObjects)
                {
                    if (cur.Name == query)
                        return cur;
                    result = cur.SearchFullName(query);
                    if (result == null)
                        continue;
                    else 
                        return result;
                    
                }
                return result;
            }
            return result;
        }
        public virtual double UrbanPopulation()
        {
            double UrbanPopualtion = 0;
            if (TypeOF == 3)
            {
                foreach (TerritoryObject cur in childObjects)
                {
                    UrbanPopualtion += cur.Population;
                }
           }
            if (TypeOF == 2)
            {
                int i;
                foreach (TerritoryObject cur in childObjects)
                {
                    for (i = 0; i < cur.childObjects.Count; i++)
                    {
                        UrbanPopualtion += cur.childObjects[i].Population;
                    }
                }
            }
            return UrbanPopualtion / Population;
            
        }
        public virtual void AddChild(TerritoryObject current)
        {
            childObjects.Add(current);
        }
        public virtual TerritoryObject GetChildByName(string name)
        {
            foreach (TerritoryObject cur in childObjects)
            {
                if (cur.Name == name)
                {
                    return cur;
                }
            }
            return null;
        }
        public virtual int TypeOF
        {
            get
            {
                return -1;
            }
        }
        public virtual int Length
        {
            get
            {
                return childObjects.Count;
            }
        }
        
    }
}
