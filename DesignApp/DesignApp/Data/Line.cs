using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace DesignApp.Data
{
    public class Line : GraphObject
    {
        public Point XPoint { get; set; }

        public Point YPoint { get; set; }


        public override void Draw(System.Windows.Media.DrawingContext dc)
        {
            var pen = new Pen(Brushes.Black, 5);

            dc.DrawLine(pen, ToPoint(XPoint), ToPoint(YPoint));
        }

        private System.Windows.Point ToPoint(Point point)
        {
            return new System.Windows.Point((double)point.X, (double)point.Y);
        }
    }
}
