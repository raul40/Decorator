using Decorator.Services;
using Decorator.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Init();
        }

        private static void Init()
        {
            ICxPComponent GuadarCxP = new RepositorioCxPDecorator();
            ICxPComponent GuardarHistorial = new HistorialCxPDecorator(GuadarCxP);
            ICxPComponent NotificadorCorreo = new NotificacionDecorator(GuardarHistorial);
            NotificadorCorreo.EjecutarGuardado();

            Console.ReadLine();
        }
    }
}
