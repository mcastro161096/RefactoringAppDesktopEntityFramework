using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace projetoTelas
{
    class PessoaExibicao
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string PlacaMoto { get; set; }

        public  List<PessoaExibicao> RetornaPesquisa(string valorPesquisado) 
        {
            var db = new Context();
            var converteTxbPesquisa = Convert.ToString(valorPesquisado);
           return db.Database.SqlQuery<PessoaExibicao>($@"SELECT * FROM PESSOAS  WHERE NOME LIKE '%{converteTxbPesquisa}%'").ToList<PessoaExibicao>(); 
            
        }
    }
}
