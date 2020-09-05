using System;
using System.Collections.Generic;
using System.Text;

namespace RentCar.Entities
{
    class Carro
    {
        public string Modelo { get; set; }

        public Carro(string modelo)
        {
            Modelo = modelo;
        }

        public Carro()
        {
        }
    }
}
