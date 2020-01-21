using Decorator.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Services
{
    public class CxPBaseDecorator : ICxPComponent
    {
        private readonly ICxPComponent Componente;
        public CxPBaseDecorator(ICxPComponent _Componente)
        {
            this.Componente = _Componente ?? throw new ArgumentException(nameof(_Componente));
        }

        public virtual void EjecutarGuardado()
        {
            if (this.Componente != null)
            {
                this.Componente.EjecutarGuardado();
            }
        }
    }
}
