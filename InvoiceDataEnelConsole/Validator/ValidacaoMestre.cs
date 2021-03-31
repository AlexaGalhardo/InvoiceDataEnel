using System.Text.RegularExpressions;
using System;
using System.Collections.Generic;
using System.Text;

namespace InvoiceDataEnelConsole.Validator
{
    class ValidacaoMestre
    {
        public List<Model.RecordError> Validar(Model.InvoiceData model)
        {
            List<Model.RecordError> ListaErros = new List<Model.RecordError>();
            Model.RecordError Erro = new Model.RecordError();

            if (model.Cliente.Length != 10)
            {
                Erro.Error = " incompleto";
                Erro.Line = model.Posicao;
                Erro.Field = "Campo codigo do cliente";

                ListaErros.Add(Erro);
            }

            if (model.Cep.ToString().Length != 8)
            {
                // throw new ArgumentException("");
            }

            //Regex regex = new Regex(@"[^\d]");
            //Match match = regex.Match(model.Cliente);
            //if (match.Success)
            //{
            //    Console.WriteLine(match.Value);
            //}

            if (model.NmCasa.Length == 0)
            {
                Erro.Error = " incompleto";
                Erro.Line = model.Posicao;
                Erro.Field = "Campo codigo do cliente";

                ListaErros.Add(Erro);
            }

            if (model.Regiao == " ")
            {
                Erro.Error = " incompleto";
                Erro.Line = model.Posicao;
                Erro.Field = "Campo codigo do cliente";

                ListaErros.Add(Erro);
            }

            if (model.Dia.ToString().Length != 2 || model.Dia.ToString() == "00")
            {
                Erro.Error = " incompleto";
                Erro.Line = model.Posicao;
                Erro.Field = "Campo codigo do cliente";

                ListaErros.Add(Erro);
            }

            if(model.Mes == "" )
            {
                Erro.Error = " incompleto";
                Erro.Line = model.Posicao;
                Erro.Field = "Campo codigo do cliente";

                ListaErros.Add(Erro);
            }

            if(model.Ano == 0000)
            {
                Erro.Error = " incompleto";
                Erro.Line = model.Posicao;
                Erro.Field = "Campo codigo do cliente";

                ListaErros.Add(Erro);
            }

            if(model.Hora == 00)
            {
                Erro.Error = " incompleto";
                Erro.Line = model.Posicao;
                Erro.Field = "Campo codigo do cliente";

                ListaErros.Add(Erro);
            }

            if(model.Minuto == 00)
            {
                Erro.Error = " incompleto";
                Erro.Line = model.Posicao;
                Erro.Field = "Campo codigo do cliente";

                ListaErros.Add(Erro);
            }

            if (model.Segundo == 00)
            {
                Erro.Error = " incompleto";
                Erro.Line = model.Posicao;
                Erro.Field = "Campo codigo do cliente";

                ListaErros.Add(Erro);
            }

            if (model.Medidor == "")
            {
                Erro.Error = " incompleto";
                Erro.Line = model.Posicao;
                Erro.Field = "Campo codigo do cliente";

                ListaErros.Add(Erro);
            }

            if(model.Aparelho == 00)
            {
                Erro.Error = " incompleto";
                Erro.Line = model.Posicao;
                Erro.Field = "Campo codigo do cliente";

                ListaErros.Add(Erro);
            }

            if (model.Kw == 000000)
            {
                Erro.Error = " incompleto";
                Erro.Line = model.Posicao;
                Erro.Field = "Campo codigo do cliente";

                ListaErros.Add(Erro);
            }

            if (model.Custo == 0000000)
            {
                Erro.Error = " incompleto";
                Erro.Line = model.Posicao;
                Erro.Field = "Campo codigo do cliente";

                ListaErros.Add(Erro);
            }


            return ListaErros;
        }
    }
}
