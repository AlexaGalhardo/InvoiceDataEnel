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
                Erro.Error = " incompleto";
                Erro.Line = model.Posicao;
                Erro.Field = "Campo cep";

                ListaErros.Add(Erro);
            }


            if (model.NmCasa.Length == 0)
            {
                Erro.Error = " incompleto";
                Erro.Line = model.Posicao;
                Erro.Field = "Campo Numero";

                ListaErros.Add(Erro);
            }

            if (model.Regiao == " ")
            {
                Erro.Error = " incompleto";
                Erro.Line = model.Posicao;
                Erro.Field = "Campo Região";

                ListaErros.Add(Erro);
            }

            if (model.Dia.ToString().Length != 2 || model.Dia.ToString() == "00")
            {
                Erro.Error = " incompleto";
                Erro.Line = model.Posicao;
                Erro.Field = "Campo Dia";

                ListaErros.Add(Erro);
            }

            if(model.Mes == "" )
            {
                Erro.Error = " incompleto";
                Erro.Line = model.Posicao;
                Erro.Field = "Campo Mês";

                ListaErros.Add(Erro);
            }

            if(model.Ano == 0000)
            {
                Erro.Error = " incompleto";
                Erro.Line = model.Posicao;
                Erro.Field = "Campo Ano";

                ListaErros.Add(Erro);
            }

            if(model.Hora == 00)
            {
                Erro.Error = " incompleto";
                Erro.Line = model.Posicao;
                Erro.Field = "Campo Hora";

                ListaErros.Add(Erro);
            }

            if(model.Minuto == 00)
            {
                Erro.Error = " incompleto";
                Erro.Line = model.Posicao;
                Erro.Field = "Campo Minuto";

                ListaErros.Add(Erro);
            }

            if (model.Segundo == 00)
            {
                Erro.Error = " incompleto";
                Erro.Line = model.Posicao;
                Erro.Field = "Campo Segundo";

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
                Erro.Field = "Campo Aparelho";

                ListaErros.Add(Erro);
            }

            if (model.Kw == 000000)
            {
                Erro.Error = " incompleto";
                Erro.Line = model.Posicao;
                Erro.Field = "Campo Kw";

                ListaErros.Add(Erro);
            }

            if (model.Custo == 0000000)
            {
                Erro.Error = " incompleto";
                Erro.Line = model.Posicao;
                Erro.Field = "Campo Custo";

                ListaErros.Add(Erro);
            }

            //Regex regex = new Regex(@"[^\d]");
            //Match match = regex.Match(model.Cliente);
            //if (match.Success)
            //{
            //    Console.WriteLine(match.Value);
            //}


            return ListaErros;
        }
    }
}
