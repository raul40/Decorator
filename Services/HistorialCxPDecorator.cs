using Decorator.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Services
{
    public class HistorialCxPDecorator : CxPBaseDecorator
    {
        public HistorialCxPDecorator(ICxPComponent _Componente) : base(_Componente)
        {
        }

        public override void EjecutarGuardado()
        {
            base.EjecutarGuardado();
            Console.WriteLine("Se guardo el historial de la CxP.");
        }
    }
}
