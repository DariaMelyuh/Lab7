using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаб7__Мост_
{
    class AirConditioner : IImplementor
    {
        public void On()
        {
            Console.WriteLine("Кондиционер включен.");
        }

        public void Off()
        {
            Console.WriteLine("Кондиционер выключен.");
        }

        public void SetPower(int power)
        {
            Console.WriteLine($"Мощность кондиционера установлена ​​на {power}");
        }

        public void SetMode(int mode)
        {
            Console.WriteLine($"Режим кондиционера установлен на {mode}");
        }
    }

}
