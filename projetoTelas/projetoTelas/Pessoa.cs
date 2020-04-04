using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Windows.Forms;

namespace projetoTelas
{
    [Table("Pessoas")]
    public class Pessoa
    {
        public int IdPessoa { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string PlacaVeiculo { get; set; }
        public virtual ICollection<ServicoPrestado> ServicosPrestados { get; set; }
        public virtual Pessoa Pessoas { get; set; }


    }
}
