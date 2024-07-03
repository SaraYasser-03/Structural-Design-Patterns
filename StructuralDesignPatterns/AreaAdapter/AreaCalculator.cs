using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralDesignPatterns.AreaAdapter
{
    public class AreaCalculator //service
    {
        public double getArea(Rectangle rectangle) //implicitly defined with no interface
        {
            return rectangle.Length * rectangle.Width;

        }
    }
}
