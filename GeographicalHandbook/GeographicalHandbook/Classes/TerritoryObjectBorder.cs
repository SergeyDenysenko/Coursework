using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Drawing2D;

namespace GeographicalHandbook.Classes
{
    public class TerritoryObjectBorder
    {
        private string name;
        public GraphicsPath border;
        public TerritoryObjectBorder(string name, GraphicsPath path)
        {
            this.name = name;
            border = path;
        }
        public string Name 
        { 
            get 
            { 
                return name; 
            } 
        }
    }
}
