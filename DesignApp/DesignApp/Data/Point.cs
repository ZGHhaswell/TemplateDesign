using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace DesignApp.Data
{
    public class Point : GraphObject
    {
        public double X { get; set; }

        public double Y { get; set; }

        public Point(double x, double y, double thickness)
            : base(thickness)
        {
            X = x;
            Y = y;
        }

        public string XExpress { get; set; }

        public string YExporess { get; set; }

        public override void Draw(System.Windows.Media.DrawingContext dc)
        {
            dc.DrawEllipse(new DrawingBrush(), GreenPen, new System.Windows.Point(X, Y), 1, 1);
        }

        public override int Order
        {
            get
            {
                return 1;
            }
            
        }
    }
}
