using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralDesignPatterns.AreaAdapter
{
    public class CalculatorAdapter:AreaCalculator //Adapter
    {
        public double getArea(Triangle triangle)
        {
            Rectangle rectangle = new Rectangle();
            rectangle.Width = triangle.Base;
            rectangle.Length = triangle.Height;
            return base.getArea(rectangle);

        }
    }
}
