using System;
using System.Collections.Generic;
using System.Text;

namespace RentCar.Entities
{
    class Aluguel
    {
        public DateTime Inicial { get; set; }
        public DateTime Final { get; set; }

        public Carro Carro { get; set; }

        public Aluguel(DateTime inicial, DateTime final, Carro carro)
        {
            Inicial = inicial;
            Final = final;
            Carro = carro;
        }

        public Aluguel()
        {
        }


    }
}
