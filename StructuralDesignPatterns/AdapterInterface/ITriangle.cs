using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralDesignPatterns.AdapterInterface
{
    //client Interface
    public interface ITriangle
    {
        double getArea(double tBase, double height);

    }
}
