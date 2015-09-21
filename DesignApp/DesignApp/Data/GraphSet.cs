using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignApp.Data
{
    public class GraphSet
    {
        public List<GraphObject> GraphObjects { get;private set; }

        public GraphSet()
        {
            GraphObjects = new List<GraphObject>();
        }
    }
}
