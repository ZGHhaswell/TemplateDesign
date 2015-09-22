using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using DesignApp.Interface;

namespace DesignApp.Canvas
{
    public class TemplateCanvas : System.Windows.Controls.Canvas
    {
        protected override void OnRender(System.Windows.Media.DrawingContext dc)
        {
            var dataContext = this.DataContext as MainViewModel;

            if (dataContext == null)
            {
                base.OnRender(dc);
                return;
            }

            ITempalte graphSet = dataContext.GraphSet;

            foreach (var graphObj in graphSet.GraphObjects)
            {
                graphObj.Draw(dc);
            }
            

            base.OnRender(dc);
        }
    }
}
