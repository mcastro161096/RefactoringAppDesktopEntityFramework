using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Collections.ObjectModel;
using System.Data.SqlClient;

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
            var t = "string";

        }

        private void Novoform2()
        {
            Application.Run(new FormCadastroCliente());
        }
        
        public void botaoPesquisar(object sender, EventArgs e)
        {
            PessoaExibicao p = new PessoaExibicao();
            FormResultadoPesquisa frm3 = new FormResultadoPesquisa();
            frm3.dg.DataSource = p.RetornaPesquisa(txbPesquisa.Text); //
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
    }
}
