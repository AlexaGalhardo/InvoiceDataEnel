using System.Text.RegularExpressions;
using System;
using System.Collections.Generic;
using System.Text;

namespace InvoiceDataEnelConsole.Validator
{
    class ValidacaoMestre
    {
        public static List<Model.RecordError> Validar(Model.InvoiceData model)
        {
            RegexLib rx = new RegexLib();

            List<Model.RecordError> ListaErros = new List<Model.RecordError>();
            Model.RecordError Erro = new Model.RecordError();

            if (model.Cliente == "0000000000" || !rx.IsMatchNumeros(model.Cliente.ToString()))
            {
                Erro.Error = "Inválido ";
                Erro.Line = model.Posicao;
                Erro.Field = "Campo codigo do cliente";

                ListaErros.Add(Erro);
            }

            if (model.Cep.ToString().Length != 8 || ! rx.IsMatchNumeros(model.Cep.ToString()) )
            {
                Erro.Error = " Inválido";
                Erro.Line = model.Posicao;
                Erro.Field = "Campo cep";

                ListaErros.Add(Erro);
            }


            if (model.NmCasa == "00000")
            {
                Erro.Error = " Inválido";
                Erro.Line = model.Posicao;
                Erro.Field = "Campo Numero";

                ListaErros.Add(Erro);
            }

            if (! String.IsNullOrEmpty(model.Regiao))
            {
                Erro.Error = " Inválido";
                Erro.Line = model.Posicao;
                Erro.Field = "Campo Região";

                ListaErros.Add(Erro);
            }

            if (! rx.IsMatchNumeros(model.Dia.ToString()) || model.Dia == 00)
            {
                Erro.Error = " Inválido";
                Erro.Line = model.Posicao;
                Erro.Field = "Campo Dia";

                ListaErros.Add(Erro);
            }

            if(!String.IsNullOrEmpty(model.Mes) || !rx.IsMatchLetras(model.Mes))
            {
                Erro.Error = " Inválido";
                Erro.Line = model.Posicao;
                Erro.Field = "Campo Mês";

                ListaErros.Add(Erro);
            }

            if(model.Ano == 0000 || !rx.IsMatchNumeros(model.Ano.ToString()))
            {
                Erro.Error = "Inválido";
                Erro.Line = model.Posicao;
                Erro.Field = "Campo Ano";

                ListaErros.Add(Erro);
            }

            if(model.Hora == 00 || !rx.IsMatchNumeros(model.Hora.ToString()))
            {
                Erro.Error = "Inválido";
                Erro.Line = model.Posicao;
                Erro.Field = "Campo Hora";

                ListaErros.Add(Erro);
            }

            if(model.Minuto == 00 || !rx.IsMatchNumeros(model.Minuto.ToString()))
            {
                Erro.Error = " Inválido";
                Erro.Line = model.Posicao;
                Erro.Field = "Campo Minuto";

                ListaErros.Add(Erro);
            }

            if (model.Segundo == 00 || !rx.IsMatchNumeros(model.Segundo.ToString()))
            {
                Erro.Error = "Inválido";
                Erro.Line = model.Posicao;
                Erro.Field = "Campo Segundo";

                ListaErros.Add(Erro);
            }

            if (model.Medidor == "0000000000" || !rx.IsMatchNumeros(model.Medidor.ToString()))
            {
                Erro.Error = "Inválido";
                Erro.Line = model.Posicao;
                Erro.Field = "Campo codigo do cliente";

                ListaErros.Add(Erro);
            }

            if(model.Aparelho == 00 || !rx.IsMatchNumeros(model.Aparelho.ToString()))
            {
                Erro.Error = "Inválido";
                Erro.Line = model.Posicao;
                Erro.Field = "Campo Aparelho";

                ListaErros.Add(Erro);
            }

            if (model.Kw == 000000 || !rx.IsMatchNumeros(model.Kw.ToString()))
            {
                Erro.Error = "Inválido";
                Erro.Line = model.Posicao;
                Erro.Field = "Campo Kw";

                ListaErros.Add(Erro);
            }

            if (model.Custo == 0000000 || !rx.IsMatchNumeros(model.Custo.ToString()))
            {
                Erro.Error = "Inválido";
                Erro.Line = model.Posicao;
                Erro.Field = "Campo Custo";

                ListaErros.Add(Erro);
            }
            return ListaErros;
        }
    }
}
