using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Windows.Forms;

namespace projetoTelas
{
    [Table("Pessoas")]
    public class Pessoa
    {
        [Key]
        public int IdPessoa { get; set; }
        [MaxLength(150)]
        public string Nome { get; set; }
        [MaxLength(15)]
        public string Telefone { get; set; }
        [MaxLength(8)]
        public string PlacaVeiculo { get; set; }


    }
}
