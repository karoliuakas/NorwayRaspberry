using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorwayRaspberry.Objects
{
    public class CollectedBerriesBaseType
    {
        public string Date { get; set; }
        public List<double> KgIntoBucket { get; set; }
        public List<int> Korges { get; set; }
    }
}
