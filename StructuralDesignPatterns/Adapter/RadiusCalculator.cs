using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralDesignPatterns.Adapter
{
    public class RadiusCalculator {
        public int calculateRadius(RoundPig pig)
        {
            return pig.Radius;
        }
    }
}
