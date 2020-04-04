using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

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

            // MessageBox.Show(IdPessoaClienteSelecionado.ToString());
            var conexaoBuscaPessoa = new ConexaoComBd();
            var conexao = conexaoBuscaPessoa.AbreConexaoComBd();
            string[] nomesDasColunas = new string[3];
            nomesDasColunas[0] = "NOME";
            nomesDasColunas[1] = "TELEFONE";
            nomesDasColunas[2] = "PLACAVEICULO";
            for (int i = 0; i < 3; i++)
            {
                string cmdText = ($@"SELECT {nomesDasColunas[i]} FROM PESSOAS  WHERE CODPESSOA = {IdPessoaClienteSelecionado}");
                SqlCommand comando = new SqlCommand(cmdText, conexao);
                if (i == 0)
                    txtBoxNomePessoa.Text = comando.ExecuteScalar().ToString();
                if (i == 1)
                    txtBoxTelefone.Text = comando.ExecuteScalar().ToString();
                if (i == 2)
                {
                    txtBoxPlacaVeiculo.Text = comando.ExecuteScalar().ToString();
                    //aqui eu atualizo os comandos para buscar o serviço
                }

            }
            this.PreencheGridFormInformacoesCliente();

        }
        public object PreencheGridFormInformacoesCliente()
        {
            var conexaoBuscaPessoa = new ConexaoComBd();
            var conexao = conexaoBuscaPessoa.AbreConexaoComBd();
            var cmdText = ($@"SELECT * FROM PESSOASERVICOPRESTADO WHERE CODPESSOA = {IdPessoaClienteSelecionado} ORDER BY DATASERVICO DESC ");
            var comando = new SqlCommand(cmdText, conexao);
            SqlDataAdapter adaptador = new SqlDataAdapter(comando);
            DataTable dtLista = new DataTable();
            adaptador.Fill(dtLista);
            //dg.DataSource = dtLista;
            //PessoaServicoPrestado p = new PessoaServicoPrestado();
            //List<PessoaServicoPrestado> listaservicos = new List<PessoaServicoPrestado>();
            //foreach (DataRow dataRow in dtLista.Rows)
            //{
            //    //Adiciona na lista Especificando a clouna 
            //    p.CodPessoa = Convert.ToInt32(dataRow["CODPESSOA"]);
            //    p.CodServico = Convert.ToInt32(dataRow["CODSERVICO"]);
            //    p.DescricaoServico = dataRow["DESCRICAOSERVICO"].ToString();
            //    p.ValorTotal = Convert.ToDouble(dataRow["VALORTOTAL"]);
            //    p.ValorPago = Convert.ToDouble((dataRow["VALORPAGO"]));
            //    p.Pago = dataRow["PAGO"].ToString();
            //    p.DataServico = Convert.ToDateTime(dataRow["DATASERVICO"]);
            //    listaservicos.Add(p);
            //}
            dgInformacoes.DataSource = dtLista;
            //dg.DataSource = listaservicos.ToArray();
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
            catch (Exception)
            {
            }


            return dtLista;
        }
        private void CliqueBotaoCancelar(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CliqueBotaoSalvar(object sender, EventArgs e)
        {
            ConexaoComBd atualizadorPessoa = new ConexaoComBd();
            Pessoa pessoa = new Pessoa();
            if (txtBoxNomePessoa.Enabled == true)
            {
                pessoa.CodPessoa = IdPessoaClienteSelecionado;
                pessoa.Nome = txtBoxNomePessoa.Text.ToString();
                pessoa.Telefone = txtBoxTelefone.Text.ToString();
                pessoa.PlacaVeiculo = txtBoxPlacaVeiculo.Text.ToString();
                atualizadorPessoa.AtualizaPessoa(pessoa);
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
                formResultadoPesquisa.dg.DataSource = conexao.RetornaPesquisa(txbPesquisa.Text);
                FormInformacoesCliente.ActiveForm.Close();

            }

            return;
        }

        private void botaoAdicionarServico_Click(object sender, EventArgs e)
        {
            FormCadastroServico formCadastroServico = new FormCadastroServico(this);
            formCadastroServico.CodPessoaClienteSelecionado = this.IdPessoaClienteSelecionado;
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




