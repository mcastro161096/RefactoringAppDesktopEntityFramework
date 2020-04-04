using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace projetoTelas
{
    public partial class FormEditaOuExcluiServico : Form
    {
        public int IdServicoSelecionado { get; set; }
        public int IdPessoaClienteSelecionado { get; set; }

        public FormInformacoesCliente formInformacoesCliente;
        public FormEditaOuExcluiServico(FormInformacoesCliente f)
        {
            InitializeComponent();
            this.formInformacoesCliente = f;

        }
        private void FormEditaOuExcluiServico_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(IdServicoSelecionado.ToString());
            var buscaServico = new ConexaoComBd();
            var db = new AppContext();
            ServicoPrestado servico = buscaServico.BuscaServico(IdServicoSelecionado);
            txbValorTotal.Text = string.Format("{0:#,##0.00}", Double.Parse(servico.ValorTotal.ToString()));
            txbValorPago.Text = string.Format("{0:#,##0.00}", Double.Parse(servico.ValorPago.ToString()));
            cmbxPago.Text = servico.Pago.ToString();
            dateTimePicker1.CustomFormat = "MM/dd/yyy";
            dateTimePicker1.Value = servico.DataServico;
            txbServicoPrestado.Text = servico.DescricaoServico.ToString();
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
                    ServicoPrestado servicoEditado = new ServicoPrestado();
                    servicoEditado.IdServico = IdServicoSelecionado;
                    servicoEditado.PessoaId = IdPessoaClienteSelecionado;
                    servicoEditado.ValorTotal = Convert.ToDecimal(txbValorTotal.Text);
                    servicoEditado.ValorPago = Convert.ToDecimal(txbValorPago.Text);
                    servicoEditado.Pago = cmbxPago.SelectedItem.ToString();
                    servicoEditado.DataServico = (dateTimePicker1.Value);
                    servicoEditado.DescricaoServico = txbServicoPrestado.Text.ToString();
                    atualizaServico.AtualizaServico(servicoEditado);
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
                    excluiServico.ExcluiServico(IdServicoSelecionado);
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
