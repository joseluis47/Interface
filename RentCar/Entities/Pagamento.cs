using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace RentCar.Entities
{
    class Pagamento
    {
       public double PagamentoBasico { get; set; }
       public double Taxa { get; set; }

        public Pagamento(double pagamentoBasico, double taxa)
        {
            PagamentoBasico = pagamentoBasico;
            Taxa = taxa;
        }

        public double ValorTotal()
        {
            return PagamentoBasico + Taxa;
        }
        public Pagamento()
        {
        }

        public string Imprimir()
        {
            return
                "INVOICE: \n" +
                "Basic payment: " +
                PagamentoBasico.ToString("F2", CultureInfo.InvariantCulture) +
                "\n" +
                "Tax: " +
                Taxa.ToString("F2", CultureInfo.InvariantCulture) +
                "\n" +
                "Total payment: " +
                ValorTotal().ToString("F2", CultureInfo.InvariantCulture);

        }
        
    }
}
