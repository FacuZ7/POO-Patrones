using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Log log = Log.GetInstance("log.txt");
            Log log2 = Log.GetInstance("pepe.txt");

            log.GuardarLog("Log y Log2 son dos espacios en memoria diferente, ambos guardan un log, ambos son el mismo log o es una instancia diferente? RTA:" + ((log == log2) ? " Son el mismo log, el singleton hace que se trabaje con el mismo objeto asegurando que hay solo una instancia del mismo" : " Son diferentes log, entonces algo salio mal..."));
            Console.WriteLine("Escriba algo a guardar en el log.");
            log.GuardarLog(Console.ReadLine());
            Console.WriteLine("Presione una tecla para terminar");
            Console.ReadKey();
        }
    }
}
