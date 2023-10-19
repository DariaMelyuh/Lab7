using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаб7__Мост_
{
    public class Remote
    {
        protected IImplementor implementor;
        public int power = 0;
        public int mode = 0;

        public Remote(IImplementor implementor)
        {
            ArgumentNullException.ThrowIfNull(implementor);
            this.implementor = implementor;
        }

        public void TurnOn()
        {
            implementor.On();
        }

        public void TurnOff()
        {
            implementor.Off();
        }

        public virtual void PowerPlus()
        {
            implementor.SetPower(++power);
        }

        public virtual void PowerMinus()
        {
            implementor.SetPower(--power);
        }

        public virtual void ModeNext()
        {
            implementor.SetMode(++mode);
        }

        public virtual void ModePreview()
        {
            implementor.SetMode(--mode);
        }
    }
}
