
using System.Collections.Generic;
using System;

namespace InvoiceDataEnelConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escreva o caminho da sua fatura: ");
            //string path = @"C:\Users\mayaa\Downloads\'Invoice.data'";///Console.ReadLine();

            //List<string> invoices = FileManager(path);

            List<string> invoices = new List<string>();
            invoices.Add("00000348340483300100051Bloco 1A apto 44    ##SSP29Março     20211544230007A16894030000840001550");
            invoices.Add("#####348340483300100051                    ##SSP00Março     20211544230007A16894030000840001550");

            List<Model.InvoiceData> listaModels =  InvoiceValidatorManager(invoices);
            List<Model.RecordError> listaerrosPrincipal = new List<Model.RecordError>();
            int posicao = -1;

            foreach(Model.InvoiceData arquivo in listaModels)
            {
                List<Model.RecordError> listaerros = new List<Model.RecordError>();

               listaerros = Validator.ValidacaoMestre.Validar(listaModels[posicao + 1]);
                listaerrosPrincipal = listaerros; 

            }
            Console.WriteLine(string.Join(",",listaerrosPrincipal));

        }

        //public List<Model.RecordError> Forfalse(List<Model.InvoiceData> linha, int posicao)
        //{
        //    List<Model.RecordError> listaerros = new List<Model.RecordError>();



        //    if (linha.Count <= posicao)
        //    {
        //        listaerros = Validator.ValidacaoMestre.Validar (linha[posicao]);
        //        return listaerros + Forfalse(linha, posicao + 1);
        //    }
        //    return listaerros;

        //}
       

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
                    model.Posicao =pos + 1;
                    string teste = invoice.Substring(0, 10).PadLeft(10, '0');
                    model.Cliente = invoice.Substring(0,10).PadLeft(10, '0');
                    model.Cep = Convert.ToUInt32(invoice.Substring(10, 8));
                    model.NmCasa = invoice.Substring(18, 5).PadLeft(5, '0');
                    model.Complemento = invoice.Substring(23, 20).PadRight(20, ' ');
                    model.Regiao = invoice.Substring(43, 5).PadLeft(5, '#');
                    model.Dia = Convert.ToInt32(invoice.Substring(48, 2));
                    model.Mes = invoice.Substring(50, 10).PadRight(10, ' ');
                    model.Ano = Convert.ToInt32(invoice.Substring(60, 4));
                    model.Hora = Convert.ToInt32(invoice.Substring(64, 2).PadLeft(2, '0'));
                    model.Minuto = Convert.ToInt32(invoice.Substring(66, 2).PadLeft(2, '0'));
                    model.Segundo = Convert.ToInt32(invoice.Substring(68, 2).PadLeft(2, '0'));
                    model.Medidor = invoice.Substring(70, 10).PadLeft(2, '0');
                    model.Aparelho = Convert.ToInt32(invoice.Substring(80, 2));
                    model.Kw = Convert.ToInt32(invoice.Substring(82, 6).PadLeft(6, '0')) ;
                    model.Custo = Convert.ToDecimal(invoice.Substring(88, 7).PadLeft(7, '0'));

                    lista.Add(model);
                }
            }
            return lista;
        }
    }
}
