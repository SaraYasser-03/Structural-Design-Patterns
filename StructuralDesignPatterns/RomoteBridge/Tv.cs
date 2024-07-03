using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralDesignPatterns.RomoteBridge
{
    public class Tv : Device
    {
        public void getVolume()
        {
            Console.WriteLine("Volume: 10% From TV Device");
        }
    }
}
