﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using App01_ConsultarCEP.Servico;
using App01_ConsultarCEP.Servico.Modelo;


namespace App01_ConsultarCEP
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BOTAO.Clicked += BuscarCEP;
        }

        private void BuscarCEP(object sender, EventArgs args)
        {
            //1.TODO - Lógica de programação

            //1.1 TODO - Validações

            //1.2 TODO - Consulta a API
            string cep = CEP.Text.Trim();
            if (isValidCEP(cep))
            {
                try
                {
                    Endereco end = ViaCEPServico.BuscarEnderecoViaCEP(CEP.Text);
                    if (isFoundCEP(end))
                    {
                        RESULTADO.Text = string.Format("{2} /n Bairro {3} /n - {0}/{1}", end.localidade, end.uf, end.logradouro, end.bairro);
                    }
                    else
                    {
                        RESULTADO.Text = "";
                    }
                }
                catch (Exception e)
                {
                    DisplayAlert("Erro Crítico",e.Message,"OK");
                }


            }
        }

        private bool isValidCEP(string CEP)
        {
            bool valido = true;
            string mensagemErro = "";

            //TODO - Validar se tem 8 posições
            if (CEP.Length != 8)
            {
                //TDOD - Tratar erro
                mensagemErro = "O CEP Deve conter 8 caracteres.";
                valido = false;
            }
            //TODO - Validar se é numérico(tentar converter para numérico)
            int NovoCEP = 0;
            if (!int.TryParse(CEP, out NovoCEP))
            {
                //TDOD - Tratar erro
                mensagemErro = mensagemErro + "\nO CEP Deve deve ser composto apenas por números.";
                valido = false;
            }
            if (valido == false)
            {
                DisplayAlert("ERRO", mensagemErro, "Ok");
            }
            return valido;
        }

        private bool isFoundCEP(Endereco endereco)
        {
            bool found = true;
            string mensagemErro = "";

            if (endereco.cep == null)
            {
                found = false;
                mensagemErro = "O CEP não foi encontrado.";
            }
            if (found == false)
            {
                DisplayAlert("ALERTA", mensagemErro, "Ok");
            }
            return found;
        }
    }
}
