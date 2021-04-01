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

            
            if (model.Cliente == "0000000000" || !rx.IsMatchNumeros(model.Cliente.ToString()))
            {
                Model.RecordError Erro = new Model.RecordError();
            
                Erro.Erro = "Inválido ";
                Erro.Linha = model.Posicao;
                Erro.Campo = "Campo codigo do cliente";

                ListaErros.Add(Erro);
            }

             if (model.Cep.Length != 9 || ! rx.IsMatchCep(model.Cep))
            {
                Model.RecordError Erro = new Model.RecordError();

                Erro.Erro = " Inválido";
                Erro.Linha = model.Posicao;
                Erro.Campo = "Campo cep";

                ListaErros.Add(Erro);
            }


             if (model.NmCasa == "00000")
            {
                Model.RecordError Erro = new Model.RecordError();

                Erro.Erro = " Inválido";
                Erro.Linha = model.Posicao;
                Erro.Campo = "Campo Numero";

                ListaErros.Add(Erro);
            }

            if ( String.IsNullOrEmpty(model.Regiao))
            {
                Model.RecordError Erro = new Model.RecordError();

                Erro.Erro = " Inválido";
                Erro.Linha = model.Posicao;
                Erro.Campo = "Campo Região";

                ListaErros.Add(Erro);
            }

            if (! rx.IsMatchNumeros(model.Dia.ToString()) || model.Dia == 00)
            {
                Model.RecordError Erro = new Model.RecordError();

                Erro.Erro = " Inválido";
                Erro.Linha = model.Posicao;
                Erro.Campo = "Campo Dia";

                ListaErros.Add(Erro);
            }

            if(String.IsNullOrEmpty(model.Mes))
            {
                Model.RecordError Erro = new Model.RecordError();

                Erro.Erro = " Inválido";
                Erro.Linha = model.Posicao;
                Erro.Campo = "Campo Mês";

                ListaErros.Add(Erro);
            }

            if(model.Ano == 0000 || !rx.IsMatchNumeros(model.Ano.ToString()))
            {
                Model.RecordError Erro = new Model.RecordError();

                Erro.Erro = "Inválido";
                Erro.Linha = model.Posicao;
                Erro.Campo = "Campo Ano";

                ListaErros.Add(Erro);
            }

            if(model.Hora == 00 || !rx.IsMatchNumeros(model.Hora.ToString()))
            {
                Model.RecordError Erro = new Model.RecordError();

                Erro.Erro = "Inválido";
                Erro.Linha = model.Posicao;
                Erro.Campo = "Campo Hora";

                ListaErros.Add(Erro);
            }

            if(model.Minuto == 00 || !rx.IsMatchNumeros(model.Minuto.ToString()))
            {
                Model.RecordError Erro = new Model.RecordError();

                Erro.Erro = " Inválido";
                Erro.Linha = model.Posicao;
                Erro.Campo = "Campo Minuto";

                ListaErros.Add(Erro);
            }

            if (model.Segundo == 00 || !rx.IsMatchNumeros(model.Segundo.ToString()))
            {
                Model.RecordError Erro = new Model.RecordError();

                Erro.Erro = "Inválido";
                Erro.Linha = model.Posicao;
                Erro.Campo = "Campo Segundo";

                ListaErros.Add(Erro);
            }

            if (model.Medidor == "0000000000" || !rx.IsMatchNumeros(model.Medidor.ToString()))
            {
                Model.RecordError Erro = new Model.RecordError();

                Erro.Erro = "Inválido";
                Erro.Linha = model.Posicao;
                Erro.Campo = "Campo codigo do cliente";

                ListaErros.Add(Erro);
            }

            if(model.Aparelho == 00 || !rx.IsMatchNumeros(model.Aparelho.ToString()))
            {
                Model.RecordError Erro = new Model.RecordError();

                Erro.Erro = "Inválido";
                Erro.Linha = model.Posicao;
                Erro.Campo = "Campo Aparelho";

                ListaErros.Add(Erro);
            }

            if (model.Kw == 000000 || !rx.IsMatchNumeros(model.Kw.ToString()))
            {
                Model.RecordError Erro = new Model.RecordError();

                Erro.Erro = "Inválido";
                Erro.Linha = model.Posicao;
                Erro.Campo = "Campo Kw";

                ListaErros.Add(Erro);
            }

             if (model.Custo == 0000000 || !rx.IsMatchNumeros(model.Custo.ToString()))
            {
                Model.RecordError Erro = new Model.RecordError();

                Erro.Erro = "Inválido";
                Erro.Linha = model.Posicao;
                Erro.Campo = "Campo Custo";

                ListaErros.Add(Erro);
            }
            return ListaErros;
        }
    }
}
