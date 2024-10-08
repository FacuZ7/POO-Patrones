using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryMethod.Logistica
{
    public abstract class LogisticaFactory
    {
        /*Atributos*/
        private int FlotaDisponible { get; set; }
        /*Metodos*/
        public abstract ITransporte CrearTransporte();
    }
}
