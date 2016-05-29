using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeographicalHandbook.Classes
{
    public class Earth : TerritoryObject
    {
        public Earth()
            : base()
        {

        }

        public override int TypeOF
        {
            get
            {
                return 0;
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
