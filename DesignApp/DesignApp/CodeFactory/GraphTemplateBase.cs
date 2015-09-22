using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignApp.Data;

namespace DesignApp.CodeFactory
{
    public class GraphTemplateBase
    {
        public int OffsetX;

        public int OffSetY;

        public double Scale;

        public GraphTemplateBase()
        {
            OffsetX = 10;
            OffSetY = 10;
            Scale = 1;
        }
    }
}
