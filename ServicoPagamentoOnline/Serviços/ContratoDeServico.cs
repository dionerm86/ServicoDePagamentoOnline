using ServicoPagamentoOnline.Entidades;
using System;

namespace ServicoPagamentoOnline.Serviços
{
    class ContratoDeServico
    {
        private IServicoDePagamentoOnline _servicoDePagamentoOnline;

        public ContratoDeServico(IServicoDePagamentoOnline servicoDePagamentoOnline)
        {
            _servicoDePagamentoOnline = servicoDePagamentoOnline;
        }

        public void processoDeContrato(Contrato contrato, int numParcelas)
        {
            double cotaBasica = contrato.valorTotal / numParcelas;
            for (int i = 1; i <= numParcelas; i++)
            {
                DateTime data = contrato.data.AddMonths(i);
                double atualizaCota = cotaBasica + _servicoDePagamentoOnline.jurosDePagamento(cotaBasica, i);
                double cotaTotal = atualizaCota + _servicoDePagamentoOnline.taxaPagamento(atualizaCota);
                contrato.AddParcelas(new Parcelas(data, cotaTotal));
            }
        }
    }
}