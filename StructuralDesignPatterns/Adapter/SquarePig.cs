using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace StructuralDesignPatterns.Adapter
{
    public class SquarePig{
        public int Length { get; set; }

        public SquarePig(int length)
        {
            Length = length;
        }

    }
}
