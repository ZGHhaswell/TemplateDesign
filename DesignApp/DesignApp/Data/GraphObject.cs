using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Mime;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace DesignApp.Data
{
    public abstract class GraphObject
    {
        
        public string Name { get; set; }

        public abstract int Order { get; }

        public abstract void Draw(DrawingContext dc);

        public double Thickness = 10;

        protected GraphObject(double thickness)
        {
            Thickness = thickness;
        }
        
       
        public static Pen GreenPen = new Pen(Brushes.Green, 10);

        public static Pen GrayPen = new Pen(Brushes.Gray, 10);

        public static Pen GetPen(Brush brush, double thickness)
        {
            return new Pen(brush, thickness);
        }

        private static Typeface RemartTypeFace = new Typeface(new FontFamily("Microsoft YaHei"), new FontStyle(), new FontWeight(),
                new FontStretch());

        public static FormattedText GetFormattedText(string text, double fontSize)
        {
            var formattedText = new FormattedText(text, CultureInfo.CurrentCulture, FlowDirection.LeftToRight, RemartTypeFace, fontSize, new SolidColorBrush(Colors.Red));
            return formattedText;
        }
    }
}
