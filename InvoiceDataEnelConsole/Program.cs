using System;

namespace InvoiceDataEnelConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string registro = "00000348340483300100051Bloco 1A apto 44    ##SSP29Março     20211544230007A16894030000840001550";

            if (registro.Length <= 95)
            {
                Model.Modelo model = new Model.Modelo();
                model.Posicao = 1;

                model.Cliente = Convert.ToInt32(registro.Substring(0, 10).PadLeft(10, '0'));
                model.Cep = Convert.ToUInt32(registro.Substring(10, 8));
                model.NmCasa = registro.Substring(18, 5);
                model.Complemento = registro.Substring(23, 20);
                model.Regiao = registro.Substring(43, 5);
                model.Dia = Convert.ToInt32(registro.Substring(48, 2));
                model.Mes = registro.Substring(50, 10);
                model.Ano = Convert.ToInt32(registro.Substring(60, 4));
                model.Hora = Convert.ToInt32(registro.Substring(64, 2));
                model.Minuto = Convert.ToInt32(registro.Substring(66, 2));
                model.Segundo = Convert.ToInt32(registro.Substring(68, 2));
                model.Medidor = registro.Substring(70, 10);
                model.Aparelho = Convert.ToInt32(registro.Substring(80, 2));
                model.Kw = Convert.ToInt32(registro.Substring(82, 6));
                model.Custo = Convert.ToDecimal(registro.Substring(88, 7));

            }
        }
}
