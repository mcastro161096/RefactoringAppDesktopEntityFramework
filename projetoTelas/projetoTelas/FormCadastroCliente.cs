using System;

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
            var placaVeiculo = txtBoxPlacaMoto.Text;

            Pessoa p = new Pessoa
            {
                Nome = nomePessoa,
                Telefone = telefone,
                PlacaVeiculo = placaVeiculo
            };
            var c = new ConexaoComBd();
            c.InserePessoa(p);
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
