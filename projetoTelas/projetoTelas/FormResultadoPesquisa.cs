using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        }

        private void NovoForm4()
        {
            Application.Run(new FormCadastroServicos());
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            FormCadastroServicos frm4 = new FormCadastroServicos();
            var pessoaEscolhida = nomeDataGridViewTextBoxColumn1;
            frm4.ShowDialog();
            frm4.Refresh();


        }
    }
}
