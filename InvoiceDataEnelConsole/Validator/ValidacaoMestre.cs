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
            Model.RecordError Erro= new Model.RecordError();

            if (model.Cliente.ToString().Length != 10)
            {
                Erro.Error= " incompleto";
                Erro.Line = model.Posicao;
                Erro.Field = "Campo codigo do cliente";

                ListaErros.Add(Erro);
            }

            if(model.Cep.ToString().Length != 8)
            {
                // throw new ArgumentException("");
            }
            // if(model.)
            return ListaErros;
        }
    }
}
