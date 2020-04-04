using System;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace projetoTelas
{
    public partial class FormInicial : Form

    {
        Thread nt;

        public FormInicial()
        {
            InitializeComponent();

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Novoform2()
        {
            Application.Run(new FormCadastroCliente());
        }



        public void botaoPesquisar(object sender, EventArgs e)
        {
            FormResultadoPesquisa frm3 = new FormResultadoPesquisa();
            var db = new AppContext();
            frm3.dg.DataSource = db.Pessoas.Where(c => c.Nome.Contains(txbPesquisa.Text.ToString()));
            frm3.txbPesquisa.Text = txbPesquisa.Text;
            frm3.ShowDialog();
        }


        private void Novoform3()
        {
            Application.Run(new FormResultadoPesquisa());
        }

        private void botaoCadastrarClientes(object sender, EventArgs e)
        {
            FormCadastroCliente frm2 = new FormCadastroCliente();
            frm2.ShowDialog();
        }

        private void txbPesquisa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals((char)Keys.Enter))
                this.botaoPesquisar(sender, e);
        }
    }
}
