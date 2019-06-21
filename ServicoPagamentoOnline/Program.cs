using System;
using System.Globalization;
using ServicoPagamentoOnline.Entidades;
using ServicoPagamentoOnline.Serviços;

namespace ServicoPagamentoOnline
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com os dados do contrato: ");
            Console.Write("Número do Contrato: ");
            int numeroContrato = int.Parse(Console.ReadLine());
            Console.Write("Data (dd/MM/yyyy): ");
            DateTime dataContrato = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            Console.Write("Valor do Contrato: ");
            double valorContrato = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Qual o número de Parcelas? ");
            int numParcelas = int.Parse(Console.ReadLine());

            Contrato meuContrato = new Contrato(numeroContrato, dataContrato, valorContrato);

            ContratoDeServico contratoDeServico= new ContratoDeServico(new ServicoPayPal());
            contratoDeServico.processoDeContrato(meuContrato, numParcelas);

            Console.WriteLine("Parcelas:");
            foreach (Parcelas parcelas in meuContrato.Parcelas)
            {
                Console.WriteLine(parcelas);
            }

            Console.ReadLine();

        }
    }
}