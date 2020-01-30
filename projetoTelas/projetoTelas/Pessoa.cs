using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetoTelas
{
   public class Pessoa
    {
        public int id { get; set; }
        [MaxLength(150)]
        [Required(ErrorMessage = "Campo obrigatorio")]
        public string Nome { get; set; }
        [MaxLength(15)]
        public string Telefone { get; set; }
        [Required(ErrorMessage = "Campo obrigatorio")]
        [MaxLength(10)]
        public string PlacaMoto { get; set; }

        public void InserePessoa(Pessoa p)
        {
            var db = new Context();
            db.Pessoas.Add(p);
            try
            {
                db.SaveChanges();
                
                MessageBox.Show("Salvo com sucesso");
            }
            catch (System.Data.Entity.Validation.DbEntityValidationException)
            {
                MessageBox.Show("Preencha corretamente todos os campos do cadastro");
            }
            return;
        }
       
    }
}
