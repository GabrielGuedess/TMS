﻿using CorreioService;

namespace Interface.Properties
{
    internal class ClientCEP
    {
        public CEPModel getCEP(string CEP)
        {
            CEPModel CEPModel = new();
            try
            {

                AtendeClienteClient atendeCliente = new();
                var consultaCEP = atendeCliente.consultaCEPAsync(CEP).Result;
                if (consultaCEP != null)
                {
                    CEPModel.Bairro = consultaCEP.@return.bairro;
                    CEPModel.Cidade = consultaCEP.@return.cidade;
                    CEPModel.UF = consultaCEP.@return.uf;
                    CEPModel.Logradouro = consultaCEP.@return.end;
                    return CEPModel;
                }
                return CEPModel;
            }
            catch (System.Exception)
            {
                MessageBox.Show($"CEP não encontrado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return CEPModel;
            }
        }
    }
}
