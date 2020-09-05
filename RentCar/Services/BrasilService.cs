using System;
using System.Collections.Generic;
using System.Text;

namespace RentCar.Services
{
    class BrasilService: Itax
    {
       public double Tax(double PrecoHora, double PrecoDia, TimeSpan duracao)
        {

            if (duracao.TotalHours < 12)
            {
                return Math.Ceiling(duracao.TotalHours) * PrecoHora;
            } else
            {
                return Math.Ceiling(duracao.TotalDays) * PrecoDia;
            }

        }
    }
}
