using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetoTelas
{
    public partial class ConexaoComBd
    {
        public ServicoPrestado BuscaServico(int idServico)
        {
            var db = new AppContext();
            ServicoPrestado servico = db.ServicosPrestados.Find(idServico);
            return servico;
        }
        public void InsereServico(ServicoPrestado servico)
        {
            try
            {
                var db = new AppContext();
                db.ServicosPrestados.Add(servico);
                MessageBox.Show("Serviço salvo com sucesso!");
            }
            catch (System.Data.SqlClient.SqlException e)
            {
                MessageBox.Show(e.Message);
            }


        }
        public void AtualizaServico(ServicoPrestado servicoEditado)
        {
            try
            {
                var db = new AppContext();
                ServicoPrestado servicoAtual = db.ServicosPrestados.Find(servicoEditado.IdServico);
                servicoAtual = servicoEditado;
                db.SaveChanges();
                MessageBox.Show("Serviço editado com sucesso!");
            }
            catch (System.Data.SqlClient.SqlException e) 
            {
                MessageBox.Show(e.Message);
            }
        }
        public void ExcluiServico(int codServico)
        {

            MessageBox.Show("Serviço excluído!");

        }

    }
}
