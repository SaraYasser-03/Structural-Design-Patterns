using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralDesignPatterns.StorageBridge
{
    public abstract class BaseRepository
    {
        protected Storage storage;
        public BaseRepository(Storage storage)
        {
            this.storage = storage;
        }
        public abstract void save();
    }
}
