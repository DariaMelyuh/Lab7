using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаб7__Мост_
{
    class Remote
    {
        protected IImplementor implementor;

        public Remote(IImplementor implementor)
        {
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
            implementor.SetPower(Power() + 1);
        }

        public virtual void PowerMinus()
        {
            implementor.SetPower(Power() - 1);
        }

        public virtual void Next()
        {

        }

        public virtual void Mode()
        {
            implementor.SetMode(GetMode() + 1);
        }

        protected virtual int Power()
        {
            return 0;
        }

        protected virtual int GetMode()
        {
            return 0;
        }

    }
}
