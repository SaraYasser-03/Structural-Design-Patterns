using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralDesignPatterns.Adapter
{
    public class SquarePigAdapter:RadiusCalculator
    {
        public int calculateRadius(SquarePig squarePig)
        {
            RoundPig roundPig = new RoundPig();
            roundPig.Radius = squarePig.Length;
            int result = base.calculateRadius(roundPig);
            return result*2;
        }
    }
}
