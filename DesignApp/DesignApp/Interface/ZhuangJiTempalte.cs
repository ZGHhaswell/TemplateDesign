//       ZhuangJi 自动生成的 Code
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignApp.Data;
using DesignApp.Interface;

namespace DesignApp.CodeFactory
{
    public class ZhuangJi : GraphTemplateBase, ITempalte
    {
        public double P1 = 300;

        public double P2 = 100;

        public double P3 = 100;

        public double P4 = 100;

        
        public Point Point1
        {
            get
            {
                var x = OffsetX + (0) * Scale;
                var y = OffSetY + (0) * Scale;
                var thickness = 10;
                return new Point(x, y, thickness);
            }
        }

        public Point Point2
        {
            get
            {
                var x = OffsetX + (0) * Scale;
                var y = OffSetY + (P2) * Scale;
                var thickness = 10;
                return new Point(x, y, thickness);
            }
        }

        public Point Point3
        {
            get
            {
                var x = OffsetX + (0) * Scale;
                var y = OffSetY + (P2+P3) * Scale;
                var thickness = 10;
                return new Point(x, y, thickness);
            }
        }

        public Point Point4
        {
            get
            {
                var x = OffsetX + (0) * Scale;
                var y = OffSetY + (P2+P3+P4) * Scale;
                var thickness = 10;
                return new Point(x, y, thickness);
            }
        }

        public Point Point5
        {
            get
            {
                var x = OffsetX + (P1) * Scale;
                var y = OffSetY + (P2+P3+P4) * Scale;
                var thickness = 10;
                return new Point(x, y, thickness);
            }
        }

        public Point Point6
        {
            get
            {
                var x = OffsetX + (P1) * Scale;
                var y = OffSetY + (P2+P3) * Scale;
                var thickness = 10;
                return new Point(x, y, thickness);
            }
        }

        public Point Point7
        {
            get
            {
                var x = OffsetX + (P1) * Scale;
                var y = OffSetY + (P2) * Scale;
                var thickness = 10;
                return new Point(x, y, thickness);
            }
        }

        public Point Point8
        {
            get
            {
                var x = OffsetX + (P1) * Scale;
                var y = OffSetY + (0) * Scale;
                var thickness = 10;
                return new Point(x, y, thickness);
            }
        }

        public Point Point9
        {
            get
            {
                var x = OffsetX + (P1/2) * Scale;
                var y = OffSetY + (-50) * Scale;
                var thickness = 10;
                return new Point(x, y, thickness);
            }
        }

        
        public RemartPoint RemartPoint1
        {
            get
            {
                var x = OffsetX + (0) * Scale;
                var y = OffsetX + (-50) * Scale;
                var thickness = 10;
                return new RemartPoint(x, y, thickness);
            }
        }

        public RemartPoint RemartPoint2
        {
            get
            {
                var x = OffsetX + (P1) * Scale;
                var y = OffsetX + (-50) * Scale;
                var thickness = 10;
                return new RemartPoint(x, y, thickness);
            }
        }

        
        public Line Line1
        {
            get
            {
                var pointX = Point1;
                var pointY = Point2;
                var thickness = 12;
                return new Line(pointX, pointY, thickness);
            }
        }

        public Line Line2
        {
            get
            {
                var pointX = Point2;
                var pointY = Point3;
                var thickness = 12;
                return new Line(pointX, pointY, thickness);
            }
        }

        public Line Line3
        {
            get
            {
                var pointX = Point3;
                var pointY = Point4;
                var thickness = 12;
                return new Line(pointX, pointY, thickness);
            }
        }

        public Line Line4
        {
            get
            {
                var pointX = Point4;
                var pointY = Point5;
                var thickness = 12;
                return new Line(pointX, pointY, thickness);
            }
        }

        public Line Line5
        {
            get
            {
                var pointX = Point5;
                var pointY = Point6;
                var thickness = 12;
                return new Line(pointX, pointY, thickness);
            }
        }

        public Line Line6
        {
            get
            {
                var pointX = Point6;
                var pointY = Point7;
                var thickness = 12;
                return new Line(pointX, pointY, thickness);
            }
        }

        public Line Line7
        {
            get
            {
                var pointX = Point7;
                var pointY = Point8;
                var thickness = 12;
                return new Line(pointX, pointY, thickness);
            }
        }

        public Line Line8
        {
            get
            {
                var pointX = Point2;
                var pointY = Point7;
                var thickness = 12;
                return new Line(pointX, pointY, thickness);
            }
        }

        public Line Line9
        {
            get
            {
                var pointX = Point3;
                var pointY = Point6;
                var thickness = 12;
                return new Line(pointX, pointY, thickness);
            }
        }

        
        public RemartLine RemartLine1
        {
            get
            {
                var pointX = RemartPoint1;
                var pointY = RemartPoint2;
                var thickness = 12;
                return new RemartLine(pointX, pointY, thickness);
            }
        }

        
        public RemartText RemartText1
        {
            get
            {
                var startPoint = Point9;
                var orientation = Orientation.Hor;
                var text = P1.ToString();
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
                list.Add(Point2);
                list.Add(Point3);
                list.Add(Point4);
                list.Add(Point5);
                list.Add(Point6);
                list.Add(Point7);
                list.Add(Point8);
                list.Add(Point9);
                list.Add(RemartPoint1);
                list.Add(RemartPoint2);
                list.Add(Line1);
                list.Add(Line2);
                list.Add(Line3);
                list.Add(Line4);
                list.Add(Line5);
                list.Add(Line6);
                list.Add(Line7);
                list.Add(Line8);
                list.Add(Line9);
                list.Add(RemartLine1);
                list.Add(RemartText1);
                return list;
            }
        }
    }
}
