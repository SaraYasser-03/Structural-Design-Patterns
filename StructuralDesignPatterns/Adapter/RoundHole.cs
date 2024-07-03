using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralDesignPatterns.Adapter
{
    public class RoundHole
    {
        public int Radius { get; set; }

        public RoundHole(int radius)
        {
            Radius = radius;
        }

        public bool fits(RoundPig pig)
        {
            return (this.Radius == pig.Radius);
        }
    }

}
