
using System.Collections.Generic;
using System;

namespace DadosFaturaEnelConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Me informe o caminho da sua fatura: ");
            string path = Console.ReadLine();

            List<string> faturas = FileManager(path);


            List<Model.DadosFatura> listaModels = ConversorDeModelo(faturas);
            List<Model.RegistroErro> listaerrosPrincipal = new List<Model.RegistroErro>();
            int posicao = -1;

            foreach (Model.DadosFatura arquivo in listaModels)
            {
                List<Model.RegistroErro> listaerros = new List<Model.RegistroErro>();


                listaerrosPrincipal.AddRange(Validador.ValidacaoMestre.Validar(listaModels[posicao + 1]));

            }
            listaerrosPrincipal.ForEach(x => Console.WriteLine(x.ShowError()));
            Console.ReadKey();

        }

        public static List<string> FileManager (string path)
        {
            string line;
            List<string> faturas = new List<string>();

            System.IO.StreamReader file = new System.IO.StreamReader(@path);
            while ((line = file.ReadLine()) != null)
            {
                faturas.Add(line);
            }

            file.Close();
            return faturas;
        }

        public static List<Model.DadosFatura> ConversorDeModelo(List<string> faturas)
        {
            int pos = 0;

            List<Model.DadosFatura> lista = new List<Model.DadosFatura>();

            foreach (string fatura in faturas)
            {
                if (fatura.Length <= 95)
                {
                    Model.DadosFatura model = new Model.DadosFatura();
                    model.Posicao = pos +=1 ;
                    string teste = fatura.Substring(0, 10).PadLeft(10, '0');
                    model.Cliente = fatura.Substring(0,10).PadLeft(10, '0');
                    model.Cep = fatura.Substring(10, 5)+ "-" +fatura.Substring(14,3);
                    model.NmCasa = fatura.Substring(18, 5).PadLeft(5, '0');
                    model.Complemento = fatura.Substring(23, 20).PadRight(20, ' ');
                    model.Regiao = fatura.Substring(43, 5).PadLeft(5, '#');
                    model.Dia = Convert.ToInt32(fatura.Substring(48, 2));
                    model.Mes = fatura.Substring(50, 10).PadRight(10, ' ');
                    model.Ano = Convert.ToInt32(fatura.Substring(60, 4));
                    model.Hora = Convert.ToInt32(fatura.Substring(64, 2).PadLeft(2, '0'));
                    model.Minuto = Convert.ToInt32(fatura.Substring(66, 2).PadLeft(2, '0'));
                    model.Segundo = Convert.ToInt32(fatura.Substring(68, 2).PadLeft(2, '0'));
                    model.Medidor = fatura.Substring(70, 10).PadLeft(10, '0');
                    model.Aparelho = Convert.ToInt32(fatura.Substring(80, 2));
                    model.Kw = Convert.ToInt32(fatura.Substring(82, 6).PadLeft(6, '0')) ;
                    model.Custo = Convert.ToDecimal(fatura.Substring(88, 7).PadLeft(7, '0'));

                    lista.Add(model);
                }
            }
            return lista;
        }
    }
}
