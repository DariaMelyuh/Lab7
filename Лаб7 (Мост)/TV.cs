using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаб7__Мост_
{
    class TV : IImplementor
    {
        public void On()
        {
            Console.WriteLine("Телевизор включен.");
        }

        public void Off()
        {
            Console.WriteLine("Телевизор выключен.");
        }

        public void SetPower(int power)
        {
            Console.WriteLine($"Мощность телевизора установлена ​​на {power}");
        }

        public void SetMode(int mode)
        {
            Console.WriteLine($"Режим ТВ установлен на {mode}");
        }
    }
}
