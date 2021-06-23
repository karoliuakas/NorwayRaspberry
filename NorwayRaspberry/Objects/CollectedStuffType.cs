using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorwayRaspberry.Objects
{
    public class CollectedStuffType
    {
        public Guid UserID { get; set; }
        public List<double> KgIntoBucket { get; set; }
        public List<int> Korges { get; set; }
        public List<int> Metres { get; set;  }
        public List<double> KgIntoPrivate { get; set;  }
        public DateTime Date { get; set; }

    }
}
