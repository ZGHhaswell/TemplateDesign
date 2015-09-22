using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace DesignApp.Data
{
    public class RemartLine : Line
    {
        public RemartLine(Point xp, Point yp, double thickness)
            : base(xp, yp, thickness)
        {
            
        }

        public override void Draw(System.Windows.Media.DrawingContext dc)
        {
            DrawLine(dc, GetPen(Brushes.Gray, Thickness));
        }

        public override int Order
        {
            get
            {
                return 4;
            }
        }
    }
}
