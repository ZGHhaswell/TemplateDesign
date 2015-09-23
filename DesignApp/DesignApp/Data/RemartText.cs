using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.TextFormatting;

namespace DesignApp.Data
{
    public enum Orientation
    {
        /// <summary>
        /// 横向
        /// </summary>
        Ver,
        /// <summary>
        /// 竖向
        /// </summary>
        Hor
    }

    public class RemartText : GraphObject
    {
        public string Text { get; set; }

        public string TextExpress { get; set; }

        public Orientation Orientation { get; set; }

        /// <summary>
        /// 位置信息x
        /// </summary>
        public Point StartPoint { get; set; }

        public RemartText(Point startPoint, Orientation orientation, string text, double thickness)
            : base(thickness)
        {
            StartPoint = startPoint;
            Orientation = orientation;
            Text = text;
        }


        public override void Draw(System.Windows.Media.DrawingContext dc)
        {
            var formattedText = GetFormattedText(Text, Thickness);
            
            if (Orientation == Orientation.Hor)
            {
                dc.DrawText(formattedText, new System.Windows.Point(StartPoint.X - formattedText.Width/2, StartPoint.Y));
            }
            else
            {
                var rotate = new RotateTransform();
                rotate.Angle = 90;
                dc.PushTransform(rotate);
                dc.DrawText(formattedText, new System.Windows.Point(StartPoint.Y, -StartPoint.X));
                dc.Pop();
            }
            
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
