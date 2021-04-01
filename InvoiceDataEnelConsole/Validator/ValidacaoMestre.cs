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
                Erro.Erro = "Inválido ";
                Erro.Linha = model.Posicao;
                Erro.Campo = "Campo codigo do cliente";

                ListaErros.Add(Erro);
            }

            else if (model.Cep.ToString().Length != 8 || ! rx.IsMatchNumeros(model.Cep.ToString()) )
            {
                Erro.Erro = " Inválido";
                Erro.Linha = model.Posicao;
                Erro.Campo = "Campo cep";

                ListaErros.Add(Erro);
            }


            else if (model.NmCasa == "00000")
            {
                Erro.Erro = " Inválido";
                Erro.Linha = model.Posicao;
                Erro.Campo = "Campo Numero";

                ListaErros.Add(Erro);
            }

            else if (! String.IsNullOrEmpty(model.Regiao))
            {
                Erro.Erro = " Inválido";
                Erro.Linha = model.Posicao;
                Erro.Campo = "Campo Região";

                ListaErros.Add(Erro);
            }

            else if (! rx.IsMatchNumeros(model.Dia.ToString()) || model.Dia == 00)
            {
                Erro.Erro = " Inválido";
                Erro.Linha = model.Posicao;
                Erro.Campo = "Campo Dia";

                ListaErros.Add(Erro);
            }

            else if(!String.IsNullOrEmpty(model.Mes) || !rx.IsMatchLetras(model.Mes))
            {
                Erro.Erro = " Inválido";
                Erro.Linha = model.Posicao;
                Erro.Campo = "Campo Mês";

                ListaErros.Add(Erro);
            }

            else if(model.Ano == 0000 || !rx.IsMatchNumeros(model.Ano.ToString()))
            {
                Erro.Erro = "Inválido";
                Erro.Linha = model.Posicao;
                Erro.Campo = "Campo Ano";

                ListaErros.Add(Erro);
            }

            else if(model.Hora == 00 || !rx.IsMatchNumeros(model.Hora.ToString()))
            {
                Erro.Erro = "Inválido";
                Erro.Linha = model.Posicao;
                Erro.Campo = "Campo Hora";

                ListaErros.Add(Erro);
            }

            else if(model.Minuto == 00 || !rx.IsMatchNumeros(model.Minuto.ToString()))
            {
                Erro.Erro = " Inválido";
                Erro.Linha = model.Posicao;
                Erro.Campo = "Campo Minuto";

                ListaErros.Add(Erro);
            }

            else if (model.Segundo == 00 || !rx.IsMatchNumeros(model.Segundo.ToString()))
            {
                Erro.Erro = "Inválido";
                Erro.Linha = model.Posicao;
                Erro.Campo = "Campo Segundo";

                ListaErros.Add(Erro);
            }

            else if (model.Medidor == "0000000000" || !rx.IsMatchNumeros(model.Medidor.ToString()))
            {
                Erro.Erro = "Inválido";
                Erro.Linha = model.Posicao;
                Erro.Campo = "Campo codigo do cliente";

                ListaErros.Add(Erro);
            }

            else if(model.Aparelho == 00 || !rx.IsMatchNumeros(model.Aparelho.ToString()))
            {
                Erro.Erro = "Inválido";
                Erro.Linha = model.Posicao;
                Erro.Campo = "Campo Aparelho";

                ListaErros.Add(Erro);
            }

            else if (model.Kw == 000000 || !rx.IsMatchNumeros(model.Kw.ToString()))
            {
                Erro.Erro = "Inválido";
                Erro.Linha = model.Posicao;
                Erro.Campo = "Campo Kw";

                ListaErros.Add(Erro);
            }

             else if (model.Custo == 0000000 || !rx.IsMatchNumeros(model.Custo.ToString()))
            {
                Erro.Erro = "Inválido";
                Erro.Linha = model.Posicao;
                Erro.Campo = "Campo Custo";

                ListaErros.Add(Erro);
            }
            return ListaErros;
        }
    }
}
