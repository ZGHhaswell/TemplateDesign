using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using DesignApp.Data;

namespace DesignApp.CodeFactory
{
    public class GraphTemplateBase
    {
        public double OffsetX;

        public double OffSetY;

        public double MinX;

        public double MinY;

        public double MaxX;

        public double MaxY;

        public double CanvasX;

        public double CanvasY;

        public double Scale;

        public double Wraper = 100;

        public GraphTemplateBase()
        {
            OffsetX = 0;
            OffSetY = 0;
            Scale = 1;

            MinX = MinY = double.MaxValue;

            MaxX = MaxY = double.MinValue;

            CanvasX = 680;
            CanvasY = 680;
        }

        protected void UpdateTransform(Point point)
        {
            var x = point.X;
            var y = point.Y;

            if (x < 0 || y < 0)
                return;

            //刷新矩形区域
            if (x < MinX)
            {
                MinX = x;
            }

            if (y < MinY)
            {
                MinY = y;
            }

            if (x > MaxX)
            {
                MaxX = x;
            }

            if (y > MaxY)
            {
                MaxY = y;
            }
        }

        protected void UpdateLocation()
        {
            var width = MaxX - MinX;
            var height = MaxY - MinY;

            var scaleX = (CanvasX - Wraper) / width;
            var scaleY = (CanvasY - Wraper) / height;

            Scale = scaleX > scaleY ? scaleY : scaleX;



            OffsetX = (CanvasX - width * Scale) / 2;
            OffSetY = (CanvasY - height * Scale) / 2;
        }
    }
}
