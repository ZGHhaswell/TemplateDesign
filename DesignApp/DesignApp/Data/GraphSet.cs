using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignApp.Interface;

namespace DesignApp.Data
{
    public class GraphSet : ITempalte
    {
        public IList<GraphObject> GraphObjects { get;private set; }

        public GraphSet()
        {
            GraphObjects = new ObservableCollection<GraphObject>();
        }



        public Dictionary<string, int> ParamSet
        {
            get { throw new NotImplementedException(); }
        }
    }
}
