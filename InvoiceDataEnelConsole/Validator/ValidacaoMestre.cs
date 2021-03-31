using System.Text.RegularExpressions;
using System;
using System.Collections.Generic;
using System.Text;

namespace InvoiceDataEnelConsole.Validator
{
    class ValidacaoMestre
    {
        RegexLib rx = new RegexLib();
        public List<Model.RecordError> Validar(Model.InvoiceData model)
        {
            List<Model.RecordError> ListaErros = new List<Model.RecordError>();
            Model.RecordError Erro = new Model.RecordError();

                
            if (model.Cliente == "0000000000" || !rx.IsMatchNumeros(model.Cliente) )
            {
                Erro.Error = "Cliente Inválido";
                Erro.Line = model.Posicao;
                Erro.Field = "Campo codigo do cliente.";

                ListaErros.Add(Erro);
            }
            
            if(!rx.IsMatchNumeros(model.Cep.ToString()))
            {
               Erro.Error = " Inválido";
               Erro.Line = model.Posicao;
               Erro.Field = "Campo CEP";
            }

            if (!String.IsNullOrEmpty(model.NmCasa))
            {
                Erro.Error = " incompleto";
                Erro.Line = model.Posicao;
                Erro.Field = "Campo Número da casa.";

                ListaErros.Add(Erro);
            }

            if (!String.IsNullOrEmpty(model.Regiao))
            {
                Erro.Error = " incompleto";
                Erro.Line = model.Posicao;
                Erro.Field = "Campo Região.";

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
