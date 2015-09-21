using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignApp.Data
{
    public class GraphSet
    {
        public ObservableCollection<GraphObject> GraphObjects { get;private set; }

        public GraphSet()
        {
            GraphObjects = new ObservableCollection<GraphObject>();
        }
    }
}
