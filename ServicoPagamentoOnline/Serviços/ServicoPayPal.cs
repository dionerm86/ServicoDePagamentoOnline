namespace ServicoPagamentoOnline.Serviços
{
    class ServicoPayPal : IServicoDePagamentoOnline
    {
        private const double jurosMensais = 0.01;
        private const double percentualDeTaxa = 0.02;

        public double taxaPagamento(double quantia)
        {
            return quantia * jurosMensais;
        }

        public double jurosDePagamento(double quantia, int numparcelas)
        {
            return quantia * jurosMensais * numparcelas;
        }
    }
}

