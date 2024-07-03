using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralDesignPatterns.StorageBridge
{
    public class FileStorage:Storage
    {
        public void store()
        {
            Console.WriteLine("Stored in File");

        }
    }
}
