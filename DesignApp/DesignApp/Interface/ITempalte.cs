using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using DesignApp.Data;

namespace DesignApp.Interface
{
    public interface ITempalte
    {
        IList<GraphObject> GraphObjects { get; }
    }
}
