using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace projetoTelas
{

    public partial class FormCadastroServico : Form
    {
        public int IdPessoaClienteSelecionado { get; set; }
        public FormInformacoesCliente formInformacoesCliente;
        public FormCadastroServico(FormInformacoesCliente f)
        {
            InitializeComponent();
            this.formInformacoesCliente = f;
            this.dateTimePicker1.Value = DateTime.Now;
            txbValorTotal.Text = string.Format("{0:#,##0.00}", 0d);
            txbValorPago.Text = string.Format("{0:#,##0.00}", 0d);



        }

        private void botaoSalvar_Click(object sender, EventArgs e)
        {
            if (decimal.Parse(txbValorTotal.Text) < decimal.Parse(txbValorPago.Text))
                MessageBox.Show("O valor total não pode ser menor que o valor pago, por favor informe valores válidos!");
            else
            {
                try
                {
                    ConexaoComBd insereServico = new ConexaoComBd();
                    ServicoPrestado servico = new ServicoPrestado();
                    servico.PessoaId = IdPessoaClienteSelecionado;
                    servico.ValorTotal = decimal.Parse(txbValorTotal.Text);
                    servico.ValorPago = decimal.Parse(txbValorPago.Text);
                    servico.Pago = cmbxPago.SelectedItem.ToString();
                    servico.DataServico = dateTimePicker1.Value;
                    servico.DescricaoServico = txbServicoPrestado.Text.ToString();
                    insereServico.InsereServico(servico);
                    formInformacoesCliente.PreencheGridFormInformacoesCliente();
                   // formInformacoesCliente.dgInformacoes.DataSource = formInformacoesCliente.();
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void botaoCancelar_Click(object sender, EventArgs e)
        {
            this.Close();

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
