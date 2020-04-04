using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace projetoTelas
{
    public partial class FormCadastroServicos : FormInicial
    {
        public int IdPessoaClienteSelecionado { get; set; }
        public FormResultadoPesquisa formResultadoPesquisa;

        public FormCadastroServicos(FormResultadoPesquisa f)
        {
            InitializeComponent();
            this.formResultadoPesquisa = f;

        }

      
        public void Form4_Load(object sender, EventArgs e)
        {
            var db = new AppContext();
            Pessoa pessoa = db.Pessoas.Find(IdPessoaClienteSelecionado);
            txtBoxNomePessoa.Text = pessoa.Nome;
            txtBoxTelefone.Text = pessoa.Telefone;
            txtBoxPlacaVeiculo.Text = pessoa.PlacaVeiculo;
        }

        private void CliqueBotaoCancelar(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CliqueBotaoSalvar(object sender, EventArgs e)
        {
            ConexaoComBd atualizadorPessoaServico = new ConexaoComBd();
            Pessoa pessoa = new Pessoa();
            ServicoPrestado servico = new ServicoPrestado();
            if (botaEditar.Enabled == true)
            {
                pessoa.IdPessoa = IdPessoaClienteSelecionado;
                pessoa.Nome = txtBoxNomePessoa.Text.ToString();
                pessoa.Telefone = txtBoxTelefone.Text.ToString();
                pessoa.PlacaVeiculo = txtBoxPlacaVeiculo.Text.ToString();
               // servico.DescricaoServico = txbServicosPrestados.Text.ToString();
                servico.DataServico =  DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
            }
            else
            {
                pessoa.IdPessoa = IdPessoaClienteSelecionado;
                pessoa.Nome = txtBoxNomePessoa.Text.ToString();
                pessoa.Telefone = txtBoxTelefone.Text.ToString();
                pessoa.PlacaVeiculo = txtBoxPlacaVeiculo.Text.ToString();
               // servico.DescricaoServico = txbServicosPrestados.Text.ToString();
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
                conexao.ExcluirPessoaEServico(IdPessoaClienteSelecionado);
                formResultadoPesquisa.dg.DataSource = conexao.RetornaPesquisa(txbPesquisa.Text);
                FormCadastroServicos.ActiveForm.Close();

            }

            return;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
           
        }
    }

}

               

   
