using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace projetoTelas
{
    public partial class FormEditaOuExcluiServico : Form
    {
        public int CodServicoSelecionado { get; set; }
        public int CodPessoaClienteSelecionado { get; set; }

        public FormInformacoesCliente formInformacoesCliente;
        public FormEditaOuExcluiServico(FormInformacoesCliente f)
        {
            InitializeComponent();
            this.formInformacoesCliente = f;

        }
        private void FormEditaOuExcluiServico_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(CodServicoSelecionado.ToString());
            var buscaServico = new ConexaoComBd();
            var conexao = buscaServico.AbreConexaoComBd();
            var cmdtext = ($@"SELECT * FROM PESSOASERVICOPRESTADO WHERE CODSERVICO = {CodServicoSelecionado}");
            var comando = new SqlCommand(cmdtext, conexao);
            SqlDataAdapter adaptador = new SqlDataAdapter(comando);
            DataTable dtlista = new DataTable();
            adaptador.Fill(dtlista);
            PessoaServicoPrestado p = new PessoaServicoPrestado();
            List<PessoaServicoPrestado> listaservicos = new List<PessoaServicoPrestado>();
            foreach (DataRow dataRow in dtlista.Rows)
            {
                //Adiciona na lista Especificando a clouna 
                p.CodPessoa = Convert.ToInt32(dataRow["CODPESSOA"]);
                p.CodServico = Convert.ToInt32(dataRow["CODSERVICO"]);
                p.DescricaoServico = dataRow["DESCRICAOSERVICO"].ToString();
                p.ValorTotal = Convert.ToDecimal(dataRow["VALORTOTAL"]);
                p.ValorPago = Convert.ToDecimal((dataRow["VALORPAGO"]));
                p.Pago = dataRow["PAGO"].ToString();
                p.DataServico = Convert.ToDateTime(dataRow["DATASERVICO"]);
                listaservicos.Add(p);
            }
            txbValorTotal.Text = string.Format("{0:#,##0.00}", Double.Parse(p.ValorTotal.ToString()));
            txbValorPago.Text = string.Format("{0:#,##0.00}", Double.Parse(p.ValorPago.ToString()));
            cmbxPago.Text = p.Pago.ToString();
            dateTimePicker1.CustomFormat = "MM/dd/yyy";
            dateTimePicker1.Value = p.DataServico;
            txbServicoPrestado.Text = p.DescricaoServico.ToString();
            this.DesabilitaCampos(false);
        }


        private void botaoCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void DesabilitaCampos(bool trueOuFalseParametro)
        {
            var trueOuFalse = trueOuFalseParametro;
            txbValorTotal.Enabled = trueOuFalseParametro;
            txbValorPago.Enabled = trueOuFalseParametro;
            txbServicoPrestado.Enabled = trueOuFalseParametro;
            cmbxPago.Enabled = trueOuFalseParametro;
            dateTimePicker1.Enabled = trueOuFalseParametro;
        }

        private void botaoEditar_Click(object sender, EventArgs e)
        {
            if (txbValorTotal.Enabled == true)
                this.DesabilitaCampos(false);
            else
                this.DesabilitaCampos(true);
        }

        private void botaoSalvar_Click(object sender, EventArgs e)
        {
            if (txbValorTotal.Enabled == false)
                MessageBox.Show("Nenhuma Alteração foi feita");
            else
            if (decimal.Parse(txbValorTotal.Text) < decimal.Parse(txbValorPago.Text))
                MessageBox.Show("O valor total não pode ser menor que o valor pago, por favor informe valores válidos!");
           else
           {
                try
                {
                    ConexaoComBd atualizaServico = new ConexaoComBd();
                    atualizaServico.AbreConexaoComBd();
                    PessoaServicoPrestado servico = new PessoaServicoPrestado();
                    servico.CodServico = CodServicoSelecionado;
                    servico.CodPessoa = CodPessoaClienteSelecionado;
                    servico.ValorTotal = Convert.ToDecimal(txbValorTotal.Text);
                    servico.ValorPago = Convert.ToDecimal(txbValorPago.Text);
                    servico.Pago = cmbxPago.SelectedItem.ToString();
                    servico.DataServico = (dateTimePicker1.Value);
                    servico.DescricaoServico = txbServicoPrestado.Text.ToString();
                    atualizaServico.AtualizaServico(servico);
                    formInformacoesCliente.dgInformacoes.DataSource = formInformacoesCliente.PreencheGridFormInformacoesCliente();
                    this.Close();
                }
                catch (Exception execaoAoAtualizarServico)
                {
                    MessageBox.Show(execaoAoAtualizarServico.Message);
                }
           }
        }

        private void botaoExcluirServico_Click(object sender, EventArgs e)
        {
            var resultado = MessageBox.Show("Ao aceitar o serviço será excluído permanentemente. Deseja excluir?", "", MessageBoxButtons.YesNoCancel);
            if (resultado == DialogResult.Yes)
            {
                try
                {
                    ConexaoComBd excluiServico = new ConexaoComBd();
                    excluiServico.AbreConexaoComBd();
                    excluiServico.ExcluiServico(CodServicoSelecionado);
                }
                catch (Exception execaoAoExcluirServico)
                {
                    MessageBox.Show(execaoAoExcluirServico.Message);
                }
                formInformacoesCliente.dgInformacoes.DataSource = formInformacoesCliente.PreencheGridFormInformacoesCliente();
                this.Close();
            }


        }
        private void txbValorTotal_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (char.IsDigit(e.KeyChar) || e.KeyChar.Equals((char)Keys.Back))
            {
                TextBox caixaDeTexto = (TextBox)sender;
                string StringDigitada = Regex.Replace(caixaDeTexto.Text, "[^0-9]", string.Empty);
                if (StringDigitada == string.Empty) StringDigitada = "00";

                if (e.KeyChar.Equals((char)Keys.Back))      //  If backspace
                    StringDigitada = StringDigitada.Substring(0, StringDigitada.Length - 1);      //      takes out the rightmost digit
                else
                    StringDigitada += e.KeyChar;
                txbValorTotal.Text = caixaDeTexto.SelectionStart.ToString();

                caixaDeTexto.Text = string.Format("{0:#,##0.00}", Double.Parse(StringDigitada) / 100);
                caixaDeTexto.Select(caixaDeTexto.Text.Length, 0);
            }
            e.Handled = true;

        }

        private void txbValorTotal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                //  Cast control
                TextBox t = (TextBox)sender;
                t.Text = string.Format("{0:#,##0.00}", 0d);
                t.Select(t.Text.Length, 0);
                e.Handled = true;
            }
        }

        private void txbValorPago_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar.Equals((char)Keys.Back))
            {
                TextBox caixaDeTextoPago = (TextBox)sender;
                string StringDigitadaPago = Regex.Replace(caixaDeTextoPago.Text, "[^0-9]", string.Empty);
                if (StringDigitadaPago == string.Empty) StringDigitadaPago = "00";

                if (e.KeyChar.Equals((char)Keys.Back))      //  If backspace
                    StringDigitadaPago = StringDigitadaPago.Substring(0, StringDigitadaPago.Length - 1);      //      takes out the rightmost digit
                else
                    StringDigitadaPago += e.KeyChar;
                txbValorPago.Text = caixaDeTextoPago.SelectionStart.ToString();

                caixaDeTextoPago.Text = string.Format("{0:#,##0.00}", Double.Parse(StringDigitadaPago) / 100);
                caixaDeTextoPago.Select(caixaDeTextoPago.Text.Length, 0);
            }
            e.Handled = true;
        }

        private void txbValorPago_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                //  Cast control
                TextBox t = (TextBox)sender;
                t.Text = string.Format("{0:#,##0.00}", 0d);
                t.Select(t.Text.Length, 0);
                e.Handled = true;
            }
        }

        private void txbValorTotal_Leave(object sender, EventArgs e)
        {
            if (decimal.Parse(txbValorTotal.Text) > decimal.Parse(txbValorPago.Text) && decimal.Parse(txbValorPago.Text) != 0)
                cmbxPago.Text = "Parcial";
            else
           if (decimal.Parse(txbValorTotal.Text) > decimal.Parse(txbValorPago.Text) && decimal.Parse(txbValorPago.Text) == 0)
                cmbxPago.Text = "Não";
            else
           if (decimal.Parse(txbValorTotal.Text) == decimal.Parse(txbValorPago.Text))
                cmbxPago.Text = "Sim";
            else
           if (decimal.Parse(txbValorTotal.Text) < decimal.Parse(txbValorPago.Text))
                MessageBox.Show("O valor total não pode ser menor que o valor pago, por favor informe valores válidos!");
        }

        private void txbValorPago_Leave(object sender, EventArgs e)
        {
            if (decimal.Parse(txbValorTotal.Text) > decimal.Parse(txbValorPago.Text) && decimal.Parse(txbValorPago.Text) != 0)
                cmbxPago.Text = "Parcial";
            else
           if (decimal.Parse(txbValorTotal.Text) > decimal.Parse(txbValorPago.Text) && decimal.Parse(txbValorPago.Text) == 0)
                cmbxPago.Text = "Não";
            else
           if (decimal.Parse(txbValorTotal.Text) == decimal.Parse(txbValorPago.Text))
                cmbxPago.Text = "Sim";
            else
           if (decimal.Parse(txbValorTotal.Text) < decimal.Parse(txbValorPago.Text))
                MessageBox.Show("O valor total não pode ser menor que o valor pago, por favor informe valores válidos!");
        }
    }
}
