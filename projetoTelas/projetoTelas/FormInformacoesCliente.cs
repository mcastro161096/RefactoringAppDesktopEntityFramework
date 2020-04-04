using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using static projetoTelas.ConexaoComBd;

namespace projetoTelas
{
    public partial class FormInformacoesCliente : FormInicial
    {
        public int IdPessoaClienteSelecionado { get; set; }
        public FormResultadoPesquisa formResultadoPesquisa;
        public DataGridView dgInformacoes { get; set; }

        public FormInformacoesCliente(FormResultadoPesquisa f)
        {
            InitializeComponent();
            this.formResultadoPesquisa = f;
            dgInformacoes = dataGridView1;

        }



        public void Form4_Load(object sender, EventArgs e)
        {
            var db = new AppContext();
            Pessoa pessoa = db.Pessoas.Find(IdPessoaClienteSelecionado);
            txtBoxNomePessoa.Text = pessoa.Nome;
            txtBoxTelefone.Text = pessoa.Telefone;
            txtBoxPlacaVeiculo.Text = pessoa.PlacaVeiculo;
            this.PreencheGridFormInformacoesCliente();

        }
        public object PreencheGridFormInformacoesCliente()
        {
            var db = new AppContext();
            IEnumerable<ServicoPrestado> servicos = db.ServicosPrestados.Where(c => c.PessoaId ==IdPessoaClienteSelecionado);
            dgInformacoes.DataSource = servicos;
            try
            {
                foreach (DataGridViewRow linha in dgInformacoes.Rows)
                {
                    if (linha.Cells["PAGO"].Value.ToString() == "Não")
                        linha.DefaultCellStyle.BackColor = Color.Red;
                    if (linha.Cells["PAGO"].Value.ToString() == "Sim")
                        linha.DefaultCellStyle.BackColor = Color.Green;
                    if (linha.Cells["PAGO"].Value.ToString() == "Parcial")
                        linha.DefaultCellStyle.BackColor = Color.Yellow;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return servicos;
        }
        private void CliqueBotaoCancelar(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CliqueBotaoSalvar(object sender, EventArgs e)
        {
            ConexaoComBd conexaoComBd = new ConexaoComBd();
            Pessoa pessoa = new Pessoa();
            if (txtBoxNomePessoa.Enabled == true)
            {
                pessoa.IdPessoa = IdPessoaClienteSelecionado;
                pessoa.Nome = txtBoxNomePessoa.Text.ToString();
                pessoa.Telefone = txtBoxTelefone.Text.ToString();
                pessoa.PlacaVeiculo = txtBoxPlacaVeiculo.Text.ToString();
               conexaoComBd.AtualizaPessoa(pessoa);
                formResultadoPesquisa.FormResultadoPesquisa_Load_1(sender, e);
            }
            else
            {
                MessageBox.Show("Nenhuma alteração foi feita");

            }
        }

        private void botaEditar_Click(object sender, EventArgs e)
        {
            if (txtBoxNomePessoa.Enabled == false)
            {
                txtBoxNomePessoa.Enabled = true;
                txtBoxTelefone.Enabled = true;
                txtBoxPlacaVeiculo.Enabled = true;
            }
            else
            {
                txtBoxNomePessoa.Enabled = false;
                txtBoxTelefone.Enabled = false;
                txtBoxPlacaVeiculo.Enabled = false;
            }

        }


        private void botaoExcluir_Click(object sender, EventArgs e)
        {
            var resultado = MessageBox.Show("Ao aceitar o cliente será excluido e todos os seus serviços também. Deseja excluir?", "", MessageBoxButtons.YesNoCancel);
            if (resultado == DialogResult.Yes)
            {
                ConexaoComBd conexao = new ConexaoComBd();
                conexao.ExcluirPessoaEServico(IdPessoaClienteSelecionado);
                formResultadoPesquisa.dg.DataSource = conexao.BuscaPessoas(txbPesquisa.Text);
                FormInformacoesCliente.ActiveForm.Close();
            }
        }

        private void botaoAdicionarServico_Click(object sender, EventArgs e)
        {
            FormCadastroServico formCadastroServico = new FormCadastroServico(this);
            formCadastroServico.IdPessoaClienteSelecionado = this.IdPessoaClienteSelecionado;
            formCadastroServico.ShowDialog();
        }



        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FormEditaOuExcluiServico formEditaOuExcluiServico = new FormEditaOuExcluiServico(this);
            int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
            formEditaOuExcluiServico.CodServicoSelecionado = Convert.ToInt32(selectedRow.Cells[0].Value);
            formEditaOuExcluiServico.CodPessoaClienteSelecionado = this.IdPessoaClienteSelecionado;
            formEditaOuExcluiServico.ShowDialog();
        }
    }

}




