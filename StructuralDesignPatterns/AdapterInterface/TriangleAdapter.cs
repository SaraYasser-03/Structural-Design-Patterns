using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralDesignPatterns.AdapterInterface
{
    //adapter
    public class TriangleAdapter : ITriangle
    {
        IRectangle rectangle; //service instance

        public TriangleAdapter(IRectangle rectangle)
        {
            this.rectangle = rectangle;
        }

        public double getArea(double tBase, double height) //translates method
        {
            return 0.5 * tBase * height;
        }
    }
}
