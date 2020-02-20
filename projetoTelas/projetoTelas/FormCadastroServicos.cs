using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace projetoTelas
{
    public partial class FormCadastroServicos : FormInicial
    {
        public int CodPessoaClienteSelecionado { get; set; }
        public FormResultadoPesquisa formResultadoPesquisa;

        public FormCadastroServicos(FormResultadoPesquisa f)
        {
            InitializeComponent();
            this.formResultadoPesquisa = f;

        }

      

        public void Form4_Load(object sender, EventArgs e)
        {
            // MessageBox.Show(CodPessoaClienteSelecionado.ToString());
            var conexaoBuscaPessoa = new ConexaoComBd();
            var conexao = conexaoBuscaPessoa.AbreConexaoComBd();
            string[] nomesDasColunas = new string[3];
            nomesDasColunas[0] = "NOME";
            nomesDasColunas[1] = "TELEFONE";
            nomesDasColunas[2] = "PLACAVEICULO";
            for (int i = 0; i < 3; i++)
            {
                string cmdText = ($@"SELECT {nomesDasColunas[i]} FROM PESSOAS  WHERE CODPESSOA = {CodPessoaClienteSelecionado}");
                SqlCommand comando = new SqlCommand(cmdText, conexao);
                if (i == 0)
                    txtBoxNomePessoa.Text = comando.ExecuteScalar().ToString();
                if (i == 1)
                    txtBoxTelefone.Text = comando.ExecuteScalar().ToString();
                if (i == 2)
                {
                    txtBoxPlacaVeiculo.Text = comando.ExecuteScalar().ToString();
                    //aqui eu atualizo os comandos para buscar o serviço
                    cmdText = ($@"SELECT DESCRICAOSERVICO FROM PESSOASERVICOPRESTADO WHERE CODPESSOA = {CodPessoaClienteSelecionado} ");
                    comando = new SqlCommand(cmdText, conexao);
                    txbServicosPrestados.Text = comando.ExecuteScalar()?.ToString() ?? "";

                }
            }
        }

        private void CliqueBotaoCancelar(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CliqueBotaoSalvar(object sender, EventArgs e)
        {
            ConexaoComBd atualizadorPessoaServico = new ConexaoComBd();
            Pessoa pessoa = new Pessoa();
            PessoaServicoPrestado servico = new PessoaServicoPrestado();
            if (botaEditar.Enabled == true)
            {
                pessoa.CodPessoa = CodPessoaClienteSelecionado;
                pessoa.Nome = txtBoxNomePessoa.Text.ToString();
                pessoa.Telefone = txtBoxTelefone.Text.ToString();
                pessoa.PlacaVeiculo = txtBoxPlacaVeiculo.Text.ToString();
                servico.DescricaoServico = txbServicosPrestados.Text.ToString();
                servico.DataServico =  DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
            }
            else
            {
                pessoa.CodPessoa = CodPessoaClienteSelecionado;
                pessoa.Nome = txtBoxNomePessoa.Text.ToString();
                pessoa.Telefone = txtBoxTelefone.Text.ToString();
                pessoa.PlacaVeiculo = txtBoxPlacaVeiculo.Text.ToString();
                servico.DescricaoServico = txbServicosPrestados.Text.ToString();
                servico.DataServico = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");

            }
            atualizadorPessoaServico.AtualizaPessoaEServico(pessoa, servico);
        }

        private void botaEditar_Click(object sender, EventArgs e)
        {
            txtBoxNomePessoa.Enabled = true;
            txtBoxTelefone.Enabled = true;
            txtBoxPlacaVeiculo.Enabled = true;
        }

        private void botaoExcluir_Click(object sender, EventArgs e)
        {

            var resultado = MessageBox.Show("Ao clicar em 'OK', o cliente será excluido e todos os seus serviços também. Deseja excluir", "", MessageBoxButtons.YesNoCancel);
            if (resultado == DialogResult.Yes)
            {
                ConexaoComBd conexao = new ConexaoComBd();
                conexao.ExcluirPessoaEServico(CodPessoaClienteSelecionado);
                formResultadoPesquisa.dg.DataSource = conexao.RetornaPesquisa(txbPesquisa.Text);
                FormCadastroServicos.ActiveForm.Close();

            }

            return;
        }
       




    }

}

               

   
