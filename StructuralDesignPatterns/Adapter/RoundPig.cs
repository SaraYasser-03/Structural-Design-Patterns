using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralDesignPatterns.Adapter
{
    public class RoundPig {
        public int Radius { get; set; }

        public RoundPig(int radius)
        {
            Radius = radius;
        }

        public RoundPig()
        {
        }

    }
}
