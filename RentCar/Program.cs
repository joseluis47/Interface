using RentCar.Entities;
using System;
using System.Globalization;

namespace RentCar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter rental data ");
            Console.Write("Car Model");
            string model = Console.ReadLine();
            Carro carro = new Carro(model);
 
            Console.Write("Pickup(dd / MM / yyyy hh: mm): ");
            DateTime inicial = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH: mm", CultureInfo.InvariantCulture);
            Console.Write("Return(dd / MM / yyyy hh: mm): ");
            DateTime final = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH: mm", CultureInfo.InvariantCulture);
            Aluguel aluguel = new Aluguel(inicial, final, carro);
        }
    }
}
