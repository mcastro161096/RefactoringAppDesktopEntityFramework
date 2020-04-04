﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoTelas
{
   public partial class ConexaoComBd
    {
        public void InsereServico(ServicoPrestado servico)
        {
            try
            {
                var db = new AppContext();
                db.ServicosPrestados.Add(servico);
                MessageBox.Show("Serviço salvo com sucesso!");
            }
            catch (System.Data.SqlClient.SqlException e)
            {
                MessageBox.Show(e.Message);
            }


        }
        public void AtualizaServico(ServicoPrestado servico)
        {
            try
            {

                MessageBox.Show("Serviço editado com sucesso!");
            }
            catch (System.Data.SqlClient.SqlException e) //when (e.ParamName.Contains("Dados binários ou de string seriam truncados."))
            {
                MessageBox.Show(e.Message);
            }
        }
        public void ExcluiServico(int codServico)
        {

            MessageBox.Show("Serviço excluído!");

        }

    }
}
