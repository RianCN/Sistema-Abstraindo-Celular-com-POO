using DesafioPOO.Models;
using System;

namespace DesafioPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Iphone:");
            Iphone iphone = new Iphone("987654321", "iPhone Model", "IMEI987", 64);
            iphone.Ligar();
            iphone.ReceberLigacao();
            iphone.InstalarAplicativo("Netflix");

            Console.ReadLine();

            Console.WriteLine("Nokia:");
            Nokia nokia = new Nokia("123456789", "Nokia Model", "IMEI123", 16);
            nokia.Ligar();
            nokia.ReceberLigacao();
            nokia.InstalarAplicativo("YouTube");

            Console.WriteLine();
        }
    }
}
