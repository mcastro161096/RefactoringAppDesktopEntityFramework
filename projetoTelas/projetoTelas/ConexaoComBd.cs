using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace projetoTelas
{
    public class ConexaoComBd
    {

        public SqlConnection AbreConexaoComBd()
        {
            string conexaostring = "Data Source=MCASTRO;Initial Catalog=dbProjeto;Persist Security Info=True;User ID=sa;Password=mcastro";
            SqlConnection conexao = new SqlConnection(conexaostring);
            conexao.Open();
            return conexao;
        }
        public void InserePessoa(Pessoa p)
        {
            var conexaoInserePessoa = new ConexaoComBd();
            var conexao = conexaoInserePessoa.AbreConexaoComBd();
            string cmdText = $@"INSERT INTO PESSOAS (NOME, TELEFONE, PLACAVEICULO) VALUES ('{p.Nome.ToString()}', '{p.Telefone.ToString()}','{p.PlacaVeiculo.ToString()}')";
            SqlCommand comando = new SqlCommand(cmdText, conexao);
            comando.ExecuteNonQuery();
            MessageBox.Show("Salvo com sucesso");

            conexao.Close();

            return;
        }

        public void AtualizaPessoaEServico(Pessoa pessoa, PessoaServicoPrestado servico)
        {
            var conexaoAtualizaPessoa = new ConexaoComBd();
            var conexao = conexaoAtualizaPessoa.AbreConexaoComBd();
            var cmdText = $@"SELECT CODPESSOA FROM PESSOASERVICOPRESTADO WHERE CODPESSOA = '{pessoa.CodPessoa}'";
            SqlCommand comando = new SqlCommand(cmdText, conexao);
            comando.ExecuteScalar();
             var verificaSeJaTemServico = comando.ExecuteScalar();

            if (verificaSeJaTemServico == null)
            {
                cmdText = ($@"INSERT INTO PESSOASERVICOPRESTADO (CODPESSOA, DESCRICAOSERVICO,  DATASERVICO ) VALUES ({pessoa.CodPessoa}, '{servico.DescricaoServico} +{servico.DataServico}', '{servico.DataServico}')");
                //fazInsertNaTabela
                comando = new SqlCommand(cmdText, conexao);
                comando.ExecuteNonQuery();
                MessageBox.Show("Serviço salvo com sucesso!");
            }
            else
            {
                try
                {
                    cmdText = ($@"UPDATE PESSOAS SET NOME = '{pessoa.Nome.ToString()}' WHERE CODPESSOA = {pessoa.CodPessoa}
                UPDATE PESSOAS SET TELEFONE = '{pessoa.Telefone.ToString()}' WHERE CODPESSOA = {pessoa.CodPessoa}
                UPDATE PESSOAS SET PLACAVEICULO = '{pessoa.PlacaVeiculo.ToString()}' WHERE CODPESSOA = {pessoa.CodPessoa}
                UPDATE PESSOASERVICOPRESTADO SET DESCRICAOSERVICO = '{servico.DescricaoServico.ToString()}' WHERE CODPESSOA = {pessoa.CodPessoa}");
                    //fazUpdateSeJaExiste
                    comando = new SqlCommand(cmdText, conexao);
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Salvo com sucesso");
                }
                catch (System.Data.SqlClient.SqlException e) //when (e.ParamName.Contains("Dados binários ou de string seriam truncados."))
                {
                    MessageBox.Show(e.Message);
                }                

            }
        }

        public object RetornaPesquisa(string valorPesquisado)
        {
            var retornaPesquisa = new ConexaoComBd();
           var conexao =retornaPesquisa.AbreConexaoComBd();
            var converteTxbPesquisa = Convert.ToString(valorPesquisado);
            var cmdtxt = ($@"SELECT * FROM PESSOAS  WHERE NOME LIKE '%{converteTxbPesquisa}%'");
            SqlCommand comando = new SqlCommand(cmdtxt, conexao);
            SqlDataAdapter adaptador = new SqlDataAdapter(comando);
            DataTable dtLista = new DataTable();
            adaptador.Fill(dtLista);
            return dtLista;

        }
       
        public void ExcluirPessoaEServico(int codPessoa)
        {
            try
            {
                var conexao = AbreConexaoComBd();
                var cmdtxt = ($@"DELETE FROM PESSOASERVICOPRESTADO WHERE CODPESSOA = {codPessoa}
                                 DELETE FROM PESSOAS WHERE CODPESSOA = {codPessoa} ");
                SqlCommand comando = new SqlCommand(cmdtxt, conexao);
                comando.ExecuteNonQuery();
                MessageBox.Show("Excluído com sucesso");
                
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
          

        }

    }
   
}