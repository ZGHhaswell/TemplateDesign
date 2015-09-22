using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignApp.Data;
using DesignApp.Interface;

namespace DesignApp.CodeFactory
{
    public class GraphTemplate : GraphTemplateBase, ITempalte
    {
        public GraphTemplate()
        {
        }

        public double Param1 = 1;

        public Point Point1
        {
            get
            {
                var x = OffsetX + 1 * Scale;
                var y = OffSetY + 1 * Scale;
                var thickness = 10;
                return new Point(x, y, thickness);
            }
        }

        public RemartPoint RemartPoint1
        {
            get
            {
                var x = OffsetX + 1 * Scale;
                var y = OffsetX + 1 * Scale;
                var thickness = 10;
                return new RemartPoint(x, y, thickness);
            }
        }

        public Line Line1
        {
            get
            {
                var pointX = Point1;
                var pointY = Point1;
                var thickness = 12;
                return new Line(pointX, pointY, thickness);
            }
        }

        public RemartLine RemartLine1
        {
            get
            {
                var pointX = Point1;
                var pointY = Point1;
                var thickness = 12;
                return new RemartLine(pointX, pointY, thickness);
            }
        }

        public RemartText RemartText1
        {
            get
            {
                var startPoint = Point1;
                var orientation = Orientation.Ver;
                var text = "";
                var thickness = 12;
                return new RemartText(startPoint, orientation, text, thickness);
            }
        }



        public IList<GraphObject> GraphObjects
        {
            get
            {
                var list = new List<GraphObject>();
                list.Add(Point1);
                list.Add(RemartPoint1);
                list.Add(Line1);
                list.Add(RemartLine1);
                list.Add(RemartText1);
                return list;
            }
        }


    }
}
