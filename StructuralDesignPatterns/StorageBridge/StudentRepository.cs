using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralDesignPatterns.StorageBridge
{
    public class StudentRepository:BaseRepository
    {
        public StudentRepository(Storage storage):base(storage) { }

        public override void save()
        {
            storage.store();
        }

    }
}
