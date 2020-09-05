

using System;

namespace RentCar.Services
{
    interface Itax
    {
        double Tax(double PrecoHora, double PrecoDia, TimeSpan duracao);
    }
}
