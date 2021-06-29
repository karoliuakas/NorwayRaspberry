using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorwayRaspberry.Objects
{
    public class CollectedStuffType : CollectedBerriesBaseType
    {
        public Guid UserID { get; set; }
      
        public List<double> KgIntoPrivate { get; set; }
    
        public List<int> Metres { get; set;  }

    }
}
