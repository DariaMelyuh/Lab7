using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаб7__Мост_
{
   public class TV : IImplementor
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
            ArgumentNullException.ThrowIfNull(power);
            Console.WriteLine("Мощность телевизора установлена ​​на {0}",power);
        }

        public void SetMode(int mode)
        {
            ArgumentNullException.ThrowIfNull(mode);
            Console.WriteLine("Режим ТВ установлен на {0}",mode);
        }
    }
}
