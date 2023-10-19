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
            ArgumentNullException.ThrowIfNull(power);
            Console.WriteLine("Мощность кондиционера установлена ​​на {0}", power);
        }

        public void SetMode(int mode)
        {
            ArgumentNullException.ThrowIfNull(mode);
            Console.WriteLine("Режим кондиционера установлен на {0}",mode);
        }
    }

}
