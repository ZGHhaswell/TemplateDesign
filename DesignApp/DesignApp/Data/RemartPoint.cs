using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignApp.Data
{
    public class RemartPoint : Point
    {
        public RemartPoint(double x, double y, double thickness)
            : base(x, y, thickness)
        {
            
        }

        public Orientation Orientation { get; set; }

        public override void Draw(System.Windows.Media.DrawingContext dc)
        {
            base.Draw(dc);
        }

        public override int Order
        {
            get
            {
                return 2;
            }

        }
    }
}
