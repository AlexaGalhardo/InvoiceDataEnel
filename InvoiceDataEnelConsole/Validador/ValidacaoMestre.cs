using System.Text.RegularExpressions;
using System;
using System.Collections.Generic;
using System.Text;

namespace DadosFaturaEnelConsole.Validador
{
    class ValidacaoMestre
    {
        public static List<Model.RegistroErro> Validar(Model.DadosFatura model)
        {   // ESCOPO ESTÁTICO - O CORPO DA FUNÇÃO É EXECUTADO NO AMBEINTE DA DEFINIÇÃO DA FUNÇÃO
            RegexLib rx = new RegexLib();

            List<Model.RegistroErro> ListaErros = new List<Model.RegistroErro>();

            //----------- Validação Cliente -----------
            if (model.Cliente == "0000000000" || !rx.IsMatchNumeros(model.Cliente.ToString()))
            {
                Model.RegistroErro Erro = new Model.RegistroErro();
            
                Erro.Erro = "Inválido ";
                Erro.Linha = model.Posicao;
                Erro.Campo = "Campo codigo do cliente";

                ListaErros.Add(Erro);
            }
            //----------- Validação do Cep -----------
            if (model.Cep.Length != 9 || ! rx.IsMatchCep(model.Cep))
            {
                Model.RegistroErro Erro = new Model.RegistroErro();

                Erro.Erro = " Inválido";
                Erro.Linha = model.Posicao;
                Erro.Campo = "Campo cep";

                ListaErros.Add(Erro);
            }

            //----------- Validação do NmCasa -----------
            if (model.NmCasa == "00000")
            {
                Model.RegistroErro Erro = new Model.RegistroErro();

                Erro.Erro = " Inválido";
                Erro.Linha = model.Posicao;
                Erro.Campo = "Campo Numero";

                ListaErros.Add(Erro);
            }
            //----------- Validação da Região -----------
            if ( String.IsNullOrEmpty(model.Regiao))
            {
                Model.RegistroErro Erro = new Model.RegistroErro();

                Erro.Erro = " Inválido";
                Erro.Linha = model.Posicao;
                Erro.Campo = "Campo Região";

                ListaErros.Add(Erro);
            }
            //----------- Validação do Dia -----------
            if (! rx.IsMatchNumeros(model.Dia.ToString()) || model.Dia == 00)
            {
                Model.RegistroErro Erro = new Model.RegistroErro();

                Erro.Erro = " Inválido";
                Erro.Linha = model.Posicao;
                Erro.Campo = "Campo Dia";

                ListaErros.Add(Erro);
            }
            //----------- Validação do Mês -----------
            if (String.IsNullOrEmpty(model.Mes))
            {
                Model.RegistroErro Erro = new Model.RegistroErro();

                Erro.Erro = " Inválido";
                Erro.Linha = model.Posicao;
                Erro.Campo = "Campo Mês";

                ListaErros.Add(Erro);
            }
            //----------- Validação do Ano -----------
            if (model.Ano == 0000 || !rx.IsMatchNumeros(model.Ano.ToString()))
            {
                Model.RegistroErro Erro = new Model.RegistroErro();

                Erro.Erro = "Inválido";
                Erro.Linha = model.Posicao;
                Erro.Campo = "Campo Ano";

                ListaErros.Add(Erro);
            }
            //----------- Validação da Hora -----------
            if (model.Hora == 00 || !rx.IsMatchNumeros(model.Hora.ToString()))
            {
                Model.RegistroErro Erro = new Model.RegistroErro();

                Erro.Erro = "Inválido";
                Erro.Linha = model.Posicao;
                Erro.Campo = "Campo Hora";

                ListaErros.Add(Erro);
            }
            //----------- Validação do Minuto -----------
            if (model.Minuto == 00 || !rx.IsMatchNumeros(model.Minuto.ToString()))
            {
                Model.RegistroErro Erro = new Model.RegistroErro();

                Erro.Erro = " Inválido";
                Erro.Linha = model.Posicao;
                Erro.Campo = "Campo Minuto";

                ListaErros.Add(Erro);
            }
            //----------- Validação do Segundo -----------
            if (model.Segundo == 00 || !rx.IsMatchNumeros(model.Segundo.ToString()))
            {
                Model.RegistroErro Erro = new Model.RegistroErro();

                Erro.Erro = "Inválido";
                Erro.Linha = model.Posicao;
                Erro.Campo = "Campo Segundo";

                ListaErros.Add(Erro);
            }
            //----------- Validação do Medidor -----------
            if (model.Medidor == "0000000000" )
            {
                Model.RegistroErro Erro = new Model.RegistroErro();

                Erro.Erro = "Inválido";
                Erro.Linha = model.Posicao;
                Erro.Campo = "Campo Medidor";

                ListaErros.Add(Erro);
            }
            //----------- Validação do Aparelho -----------
            if (model.Aparelho == 00 || !rx.IsMatchNumeros(model.Aparelho.ToString()))
            {
                Model.RegistroErro Erro = new Model.RegistroErro();

                Erro.Erro = "Inválido";
                Erro.Linha = model.Posicao;
                Erro.Campo = "Campo Aparelho";

                ListaErros.Add(Erro);
            }
            //----------- Validade do KW -----------
            if (model.Kw == 000000 || !rx.IsMatchNumeros(model.Kw.ToString()))
            {
                Model.RegistroErro Erro = new Model.RegistroErro();

                Erro.Erro = "Inválido";
                Erro.Linha = model.Posicao;
                Erro.Campo = "Campo Kw";

                ListaErros.Add(Erro);
            }
            //----------- Validação do custo -----------
            if (model.Custo == 0000000 || !rx.IsMatchNumeros(model.Custo.ToString()))
            {
                Model.RegistroErro Erro = new Model.RegistroErro();

                Erro.Erro = "Inválido";
                Erro.Linha = model.Posicao;
                Erro.Campo = "Campo Custo";

                ListaErros.Add(Erro);
            }
            return ListaErros;
        }
    }
}
