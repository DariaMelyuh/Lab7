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
            if (power != 0)
            {
                Console.WriteLine("Мощность телевизора установлена ​​на {0}", power);
            }
            else
            {
                throw new ArgumentException("Значение 'мощности' не может быть равно 0.", nameof(power));
            }
        }

        public void SetMode(int mode)
        {
            if (mode != 0)
            {
                Console.WriteLine("Режим ТВ установлен на {0}", mode);
            }
            else
            {
                throw new ArgumentException("Значение 'режима' не может быть равно 0.", nameof(mode));
            }
        }
    }
}
