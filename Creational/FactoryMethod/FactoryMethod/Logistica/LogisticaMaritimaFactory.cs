using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryMethod.Logistica
{
    class LogisticaMaritimaFactory : LogisticaFactory
    {
        public override ITransporte CrearTransporte() 
        {
            return new TransporteMaritimoProduct();
        }
    }
}
