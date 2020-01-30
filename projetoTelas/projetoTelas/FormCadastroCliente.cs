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
    public partial class FormCadastroCliente : FormInicial
    {   
        public FormCadastroCliente()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void CliqueBotaoSalvar(object sender, EventArgs e)
        {
            var nomePessoa = txtBoxNomePessoa.Text;
            var telefone = txtBoxTelefone.Text;
            var placaMoto = txtBoxPlacaMoto.Text;

            Pessoa p = new Pessoa
            {
                Nome = nomePessoa,
                Telefone = telefone,
                PlacaMoto = placaMoto
            };
                p.InserePessoa(p);
                txtBoxNomePessoa.Clear();
                txtBoxTelefone.Clear();
                txtBoxPlacaMoto.Clear();
        }

        private void CliqueBotaoCancelar(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
