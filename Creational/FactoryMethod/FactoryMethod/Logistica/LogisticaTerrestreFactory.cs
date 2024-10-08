using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryMethod.Logistica
{
    class LogisticaTerrestreFactory : LogisticaFactory
    {
        
        public override ITransporte CrearTransporte()
        {
            return new TransporteTerrestreProduct();
        }

    }
}
