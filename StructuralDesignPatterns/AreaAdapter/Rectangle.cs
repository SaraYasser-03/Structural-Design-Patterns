using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralDesignPatterns.AreaAdapter
{
    public class Rectangle //service
    {
        public Rectangle() { }
        
        public Rectangle(double length, double width) { 
            this.Length = length;
            this.Width = width;
        }

        public double Length { get; set; } 
        public double Width { get; set; }
    }
}
