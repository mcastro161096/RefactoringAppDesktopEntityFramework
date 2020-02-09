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

        private void NovoForm4()
        {
            Application.Run(new FormCadastroServicos());
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dataGridView1_RowContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //FormCadastroServicos frm4 = new FormCadastroServicos();
            //int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
            //DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
            //frm4.CodPessoaClienteSelecionado = Convert.ToInt32(selectedRow.Cells[0].Value);
            //frm4.ShowDialog();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            FormCadastroServicos frm4 = new FormCadastroServicos();
            int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
            frm4.CodPessoaClienteSelecionado = Convert.ToInt32(selectedRow.Cells[0].Value);
            frm4.ShowDialog();
        }
    }
}
