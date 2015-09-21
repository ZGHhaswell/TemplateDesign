using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace DesignApp.Data
{
    public abstract class GraphObject
    {
        public string Name { get; set; }

        public abstract void Draw(DrawingContext dc);
    }
}
