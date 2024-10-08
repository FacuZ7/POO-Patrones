using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryMethod
{
    class TransporteMaritimoProduct : ITransporte
    {
        public void Entregar() {
            Console.WriteLine("Soy un transporte maritimo entrego productos en el agua");
        }
    }
}
