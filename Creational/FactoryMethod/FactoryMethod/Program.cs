using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FactoryMethod.Logistica;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            LogisticaFactory Logistica1 = new LogisticaTerrestreFactory();
            LogisticaFactory Logistica2 = new LogisticaMaritimaFactory();

            ITransporte Transporte1 = Logistica1.CrearTransporte();
            ITransporte Transporte2 = Logistica2.CrearTransporte();

            Transporte1.Entregar();
            Transporte2.Entregar();

            Console.WriteLine("Presione cualquier tecla para finalizar");
            Console.ReadKey();
        }
    }
}
