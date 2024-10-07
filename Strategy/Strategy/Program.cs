using Strategy.IVA;
using Strategy.Service;
using System;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese un numero: ");
            string input = Console.ReadLine();
            int numero;

            if (int.TryParse(input, out numero))
            {
                Console.WriteLine("******************************");
                /*IVA 21*/
                IVAService Service21 = new IVAService(new IVA21());
                Console.WriteLine(numero + " + IVA 21:");
                Console.WriteLine(Service21.SumarIVA(numero));
                Console.WriteLine(numero + " - IVA 21:");
                Console.WriteLine(Service21.RestarIVA(numero));

                Console.WriteLine("******************************");
                /*IVA 27*/
                IVAService Service27 = new IVAService(new IVA27());
                Console.WriteLine(numero + " + IVA 27:");
                Console.WriteLine(Service27.SumarIVA(numero));
                Console.WriteLine(numero + " - IVA 27:");
                Console.WriteLine(Service27.RestarIVA(numero));

                Console.WriteLine("******************************");
                /*IVA 05*/
                IVAService Service05 = new IVAService(new IVA05());
                Console.WriteLine(numero + " + IVA 05:");
                Console.WriteLine(Service05.SumarIVA(numero));
                Console.WriteLine(numero + " - IVA 05:");
                Console.WriteLine(Service05.RestarIVA(numero));


                /*Para que no se cierre la consola hasta tocar una tecla*/
                Console.WriteLine("Toque cualquier tecla para salir");
                Console.ReadKey();   
            }
            else
            {
                Console.WriteLine("no es un numero valido.");
            }

            
        }
    }
}
