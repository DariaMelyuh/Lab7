using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаб7__Мост_
{

    class MemoryRemote : Remote
    {
        public MemoryRemote(IImplementor implementor) : base(implementor) { }

        public void Save(int index)
        {
            int power = Power();
            int mode = GetMode();

            Console.WriteLine($"Сохраненный режим {index}: Мощность {power}, Режим {mode}");
        }

        public void Load(int index)
        {

            Console.WriteLine($"Загруженный режим {index}");
        }
    }
}
