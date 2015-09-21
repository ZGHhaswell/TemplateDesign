using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignApp.Data
{
    public class RemartText : GraphObject
    {
        public string Text { get; set; }

        public string TextExpress { get; set; }

        public override void Draw(System.Windows.Media.DrawingContext dc)
        {
            
        }
    }
}
