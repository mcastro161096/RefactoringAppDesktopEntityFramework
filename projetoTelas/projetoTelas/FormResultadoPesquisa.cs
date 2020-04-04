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
       

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dbProjetoDataSet.PESSOAS'. Você pode movê-la ou removê-la conforme necessário.
            this.pESSOASTableAdapter.Fill(this.dbProjetoDataSet.PESSOAS);

        }


        public void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            FormCadastroServicos frm4 = new FormCadastroServicos(this);
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
    }
}
