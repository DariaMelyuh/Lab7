using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаб7__Мост_
{
    public class AirConditioner : IImplementor
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
            if (power > 0)
            {
                Console.WriteLine("Мощность кондиционера установлена ​​на {0}", power);
            }
            else
            {
                throw new ArgumentException("Значение 'мощности' не может быть равно 0 и отрицательно.", nameof(power));
            }
        }

        public void SetMode(int mode)
        {
            if (mode > 0)
            {
                Console.WriteLine("Режим кондиционера установлен на {0}", mode);
            }
            else
            {
                throw new ArgumentException("Значение 'режима' не может быть равно 0 и отрицательно.", nameof(mode));
            }
        }
    }

}
