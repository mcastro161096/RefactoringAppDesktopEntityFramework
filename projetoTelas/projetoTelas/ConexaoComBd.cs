using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace projetoTelas
{
    public class ConexaoComBd
    {
        // public static System.Globalization.CultureInfo DefaultThreadCurrentCulture { get; set; }
        //CultureInfo culture = CultureInfo.CreateSpecificCulture("en-BR");
        public void InserePessoa(Pessoa p)
        {
           
            MessageBox.Show("Salvo com sucesso");


            return;
        }

        public void AtualizaPessoa(Pessoa pessoaEditada)
        {
            try
            {
                var db = new AppContext();
                Pessoa pessoaAtual = db.Pessoas.Find(pessoaEditada.IdPessoa);
                pessoaAtual = pessoaEditada;
                db.SaveChanges();
                MessageBox.Show("Salvo com sucesso");
            }
            catch (System.Data.SqlClient.SqlException e) //when (e.ParamName.Contains("Dados binários ou de string seriam truncados."))
            {
                MessageBox.Show(e.Message);
            }

        }
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

        public object BuscaPessoas(string valorPesquisado)
        {
            var db = new AppContext();
            IEnumerable<Pessoa> listaPessoas = db.Pessoas.Where(c => c.Nome.Contains(valorPesquisado));
            return listaPessoas;
        }

        public void ExcluirPessoaEServico(int idPessoa)
        {
            try
            {
                var db = new AppContext();

                Pessoa pessoa = db.Pessoas.Find(idPessoa);
                db.Pessoas.Remove(pessoa);
                MessageBox.Show("O cliente e todos os seus serviços foram excluídos com sucesso");

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }


        }

    }

}