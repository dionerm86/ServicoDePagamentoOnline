using System;
using System.Collections.Generic;
using System.Text;

namespace ServicoPagamentoOnline.Entidades
{
    class Contrato
    {
        private int numeroContrato { get; set; }
        public DateTime data { get; set; }
        public double valorTotal { get; set; }
        public List<Parcelas> Parcelas { get; set; }

        public Contrato(int numeroContrato, DateTime data, double valorTotal)
        {
            this.numeroContrato = numeroContrato;
            this.data = data;
            this.valorTotal = valorTotal;
            Parcelas = new List<Parcelas>();
        }

        public void AddParcelas(Parcelas parcelas)
        {
            Parcelas.Add(parcelas);
        }
    }
}