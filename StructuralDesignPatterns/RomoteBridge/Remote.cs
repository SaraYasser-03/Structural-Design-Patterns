using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralDesignPatterns.RomoteBridge
{
    public class Remote
    {
        protected Device device;

        public Remote(Device device)
        {
            this.device = device;
        }
        public void volumeUp()
        {
            device.getVolume();
        }
    }
}
