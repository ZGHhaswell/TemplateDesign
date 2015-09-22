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

        

        public Line(Point xp, Point yp, double thickness) : base(thickness)
        {
            XPoint = xp;
            YPoint = yp;
        }

        

        public override void Draw(System.Windows.Media.DrawingContext dc)
        {
            DrawLine(dc, GetPen(Brushes.Green, Thickness));
        }

        public override int Order
        {
            get
            {
                return 3;
            }

        }

        protected System.Windows.Point ToPoint(Point point)
        {
            return new System.Windows.Point((double)point.X, (double)point.Y);
        }


        protected void DrawLine(System.Windows.Media.DrawingContext dc, Pen pen)
        {
            dc.DrawLine(pen, ToPoint(XPoint), ToPoint(YPoint));
        }
    }
}
