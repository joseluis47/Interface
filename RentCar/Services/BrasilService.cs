using System;
using System.Collections.Generic;
using System.Text;

namespace RentCar.Services
{
    class BrasilService: Itax
    {
       public double Valor(double PrecoHora, double PrecoDia, TimeSpan duracao)
        {

            if (duracao.TotalHours < 12)
            {
                return Math.Ceiling(duracao.TotalHours) * PrecoHora;
            } else
            {
                return Math.Ceiling(duracao.TotalDays) * PrecoDia;
            }

        }

        public double Tax(double Valor)
        {
            if (Valor<100)
            {
                return Valor * 0.20;
            } else
            {
                return Valor * 0.15;
            }
        }
    }
}
