using Decorator.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Services
{
    public class NotificacionDecorator : CxPBaseDecorator
    {
        public NotificacionDecorator(ICxPComponent _Componente) : base(_Componente)
        {
        }

        public override void EjecutarGuardado()
        {
            base.EjecutarGuardado();
            Console.WriteLine("Se envio un correo.");
        }
    }
}
