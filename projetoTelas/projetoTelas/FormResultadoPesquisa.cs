using System;
using System.Windows.Forms;

namespace projetoTelas
{
    public partial class FormResultadoPesquisa : FormInicial
    {
        public DataGridView dg { get; set; }
        public FormResultadoPesquisa()
        {
            InitializeComponent();
            dg = dataGridView1;            
        }
        public void FormResultadoPesquisa_Load_1(object sender, EventArgs e)
        {
            
        }
        public void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                FormInformacoesCliente frm4 = new FormInformacoesCliente(this);
                int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
                frm4.IdPessoaClienteSelecionado = Convert.ToInt32(selectedRow.Cells[0].Value);
                frm4.txbPesquisa.Text = txbPesquisa.Text;
                frm4.ShowDialog();
                //private void button1_Click(object sender, EventArgs e)
                //{
                //    FormFilho f = new FormFilho(this);
                //    f.Show();
                //    this.Text = "Eu sou o FormPai";
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


    }
}
