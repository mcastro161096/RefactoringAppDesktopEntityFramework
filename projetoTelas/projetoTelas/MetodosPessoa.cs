using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace projetoTelas
{
    public partial class ConexaoComBd
    {
        // public static System.Globalization.CultureInfo DefaultThreadCurrentCulture { get; set; }
        //CultureInfo culture = CultureInfo.CreateSpecificCulture("en-BR");
        public object BuscaPessoas(string valorPesquisado)
        {
            var db = new AppContext();
            var listaPessoas = db.Pessoas.SqlQuery($"select IdPessoa, Nome, Telefone, PlacaVeiculo from Pessoas where Nome like '%{valorPesquisado}%'").ToList(); //(c => c.Nome.Contains(valorPesquisado));
            return listaPessoas.ToList();
        }
        public void InserePessoa(Pessoa pessoa)
        {
            try
            {
                var db = new AppContext();
                db.Pessoas.Add(pessoa);
                db.SaveChanges();
                MessageBox.Show("Salvo com sucesso");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
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
        public void ExcluiPessoaEServico(int idPessoa)
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