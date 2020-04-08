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
        public ServicoPrestado BuscaUmServicoEspecifico(int idServico)
        {
            var db = new AppContext();
            ServicoPrestado servico = db.ServicosPrestados.Find(idServico);
            return servico;
        }

        public object BuscaListaDeServicos(int idPessoaClienteSelecionado)
        {
            var db = new AppContext();
            IEnumerable<ServicoPrestado> servicos = db.ServicosPrestados.Where(c => c.PessoaId == idPessoaClienteSelecionado);
            return servicos.ToList();
        }

        public void InsereServico(ServicoPrestado servico)
        {
            try
            {
                var db = new AppContext();
                db.ServicosPrestados.Add(servico);
                db.SaveChanges();
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
                servicoAtual.ValorTotal = servicoEditado.ValorTotal;
                servicoAtual.ValorPago = servicoEditado.ValorPago;
                servicoAtual.Pago = servicoEditado.Pago;
                servicoAtual.DataServico = servicoEditado.DataServico;
                servicoAtual.DescricaoServico = servicoEditado.DescricaoServico;
                db.SaveChanges();
                MessageBox.Show("Serviço editado com sucesso!");
            }
            catch (System.Data.SqlClient.SqlException e)
            {
                MessageBox.Show(e.Message);
            }
        }
        public void ExcluiServico(int idServico)
        {

            try
            {
                var db = new AppContext();
                ServicoPrestado servico = db.ServicosPrestados.Find(idServico);
                db.ServicosPrestados.Remove(servico);
                MessageBox.Show("Serviço excluído!");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }

    }
}
