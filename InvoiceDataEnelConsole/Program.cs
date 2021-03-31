
using System.Collections.Generic;
using System;

namespace InvoiceDataEnelConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escreva o caminho da sua fatura: ");
            string path = Console.ReadLine();

            List<string> invoices = FileManager(path);
            List<Model.InvoiceData> listaModels =  InvoiceValidatorManager(invoices);
            
        }


        public static List<string> FileManager (string path)
        {
            string line;
            List<string> invoices = new List<string>();

            System.IO.StreamReader file = new System.IO.StreamReader(@path);
            while ((line = file.ReadLine()) != null)
            {
                invoices.Add(line);
            }

            file.Close();
            return invoices;
        }

        public static List<Model.InvoiceData> InvoiceValidatorManager(List<string> invoices)
        {
            int pos = 0;

            List<Model.InvoiceData> lista = new List<Model.InvoiceData>();

            foreach (string invoice in invoices)
            {
                if (invoice.Length <= 95)
                {
                    Model.InvoiceData model = new Model.InvoiceData();
                    model.Posicao =+ 1;
                    model.Cliente = Convert.ToInt32(invoice.Substring(0, 10).PadLeft(10, '0'));
                    model.Cep = Convert.ToUInt32(invoice.Substring(10, 8));
                    model.NmCasa = invoice.Substring(18, 5);
                    model.Complemento = invoice.Substring(23, 20);
                    model.Regiao = invoice.Substring(43, 5);
                    model.Dia = Convert.ToInt32(invoice.Substring(48, 2));
                    model.Mes = invoice.Substring(50, 10);
                    model.Ano = Convert.ToInt32(invoice.Substring(60, 4));
                    model.Hora = Convert.ToInt32(invoice.Substring(64, 2));
                    model.Minuto = Convert.ToInt32(invoice.Substring(66, 2));
                    model.Segundo = Convert.ToInt32(invoice.Substring(68, 2));
                    model.Medidor = invoice.Substring(70, 10);
                    model.Aparelho = Convert.ToInt32(invoice.Substring(80, 2));
                    model.Kw = Convert.ToInt32(invoice.Substring(82, 6));
                    model.Custo = Convert.ToDecimal(invoice.Substring(88, 7));

                    lista.Add(model);
                }
            }
            return lista;
        }
    }
}
