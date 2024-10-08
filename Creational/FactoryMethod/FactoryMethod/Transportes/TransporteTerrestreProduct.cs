using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryMethod
{
    class TransporteTerrestreProduct : ITransporte
    {
        public void Entregar() {
            Console.WriteLine("Soy un transporte terrestre entrego productos por tierra.");
        }
    }
}
