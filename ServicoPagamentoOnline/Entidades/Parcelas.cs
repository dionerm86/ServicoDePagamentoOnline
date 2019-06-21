using System;
using System.Globalization;

namespace ServicoPagamentoOnline
{
    class Parcelas
    {
        private DateTime dataParcela;
        private double quantia;

        public Parcelas(DateTime dataParcela, double quantia)
        {
            this.dataParcela = dataParcela;
            this.quantia = quantia;
        }

        public override string ToString()
        {
            return dataParcela.ToString("dd/MM/yyyy")
                + " - "
                + quantia.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}

