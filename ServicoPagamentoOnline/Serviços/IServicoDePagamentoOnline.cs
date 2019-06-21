namespace ServicoPagamentoOnline.Serviços
{
    interface IServicoDePagamentoOnline
    {
        double taxaPagamento(double quantia);

        double jurosDePagamento(double quantia, int numParcelas);

    }
}
