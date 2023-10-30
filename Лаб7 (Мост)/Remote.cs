using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаб7__Мост_
{
    public class Remote
    {
        protected IImplementor implementor { get; private set; }    
        public int Power { get; private set; }
        public int Mode { get;private  set; }  

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
            implementor.SetPower(++Power);
        }

        public virtual void PowerMinus()
        {
            implementor.SetPower(--Power);
        }

        public virtual void ModeNext()
        {
            implementor.SetMode(++Mode);
        }

        public virtual void ModePreview()
        {
            implementor.SetMode(--Mode);
        }
    }
}
