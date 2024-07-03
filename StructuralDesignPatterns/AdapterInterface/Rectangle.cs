using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralDesignPatterns.AdapterInterface
{
    //service
    public class Rectangle : IRectangle
    {
        public double getArea(double length, double width)
        {
            return length * width;
        }
    }
}
