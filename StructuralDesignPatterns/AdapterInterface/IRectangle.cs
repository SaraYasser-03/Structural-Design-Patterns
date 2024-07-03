using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralDesignPatterns.AdapterInterface
{
    //service Interface
    public interface IRectangle
    {
        double getArea(double length, double width);
    }
}
