using RentCar.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace RentCar.Services
{
    class ServicoAluguel
    {
        public double PrecoHora { get; set; }
        public double PrecoDia { get; set; }
        public Itax Itax { get; set; }

        public ServicoAluguel(double precoHora, double precoDia, Itax itax)
        {
            PrecoHora = precoHora;
            PrecoDia = precoDia;
            Itax = itax;
        }

        public ServicoAluguel()
        {
        }
    }
}
