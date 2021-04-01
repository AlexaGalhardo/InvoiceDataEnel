using System;
using System.Collections.Generic;
using System.Text;

namespace DadosFaturaEnelConsole.Model
{
    public class RegistroErro
    {
        public string Erro { get; set; }
        public int Linha { get; set; }
        public string Campo { get; set; }


        public string ShowError()
        {
            string erro = Linha + " "+ Erro + " " + Campo;
            return erro;
        }
    }
}
