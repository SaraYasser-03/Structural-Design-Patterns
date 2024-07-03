using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralDesignPatterns.AreaAdapter
{
    public class Triangle 
    {
        public Triangle(double triangleBase, double height) {
            Base = triangleBase;
            Height = height;
        }
        public double Base {  get; set; }
        public double Height {  get; set; }

    }
}
