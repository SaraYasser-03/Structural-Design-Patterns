using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralDesignPatterns.RegisterationFacade
{
    public class DataAccessLayer
    {
        public DataAccessLayer()
        {
        }

        public void accessData()
        {
            Console.WriteLine("Data Layer Accessed");
        }
    }
}
