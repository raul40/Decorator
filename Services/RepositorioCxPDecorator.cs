using Decorator.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Services
{
    public class RepositorioCxPDecorator : ICxPComponent
    {
        public void EjecutarGuardado()
        {
            Console.WriteLine("Se ha guardado la CxP");
        }
    }
}
