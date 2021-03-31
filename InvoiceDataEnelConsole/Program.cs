
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
           // InvoiceValidatorManager(invoices);
            
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

    }
}
