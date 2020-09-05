

using System;

namespace RentCar.Services
{
    interface Itax
    {
        double Valor(double PrecoHora, double PrecoDia, TimeSpan duracao);
        double Tax(double Valor);
    }
}
