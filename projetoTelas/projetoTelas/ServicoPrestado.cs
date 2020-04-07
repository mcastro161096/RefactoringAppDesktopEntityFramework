using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace projetoTelas
{[Table("ServicosPrestados")]
    public class ServicoPrestado
    {
        [Key]
        public int IdServico { get; set; }
        [MaxLength(2000)]
        public string DescricaoServico { get; set; }
        [Range(-999999999999999999.99, 999999999999999999.99)]
        public decimal ValorTotal { get; set; }
        [Range(-999999999999999999.99, 999999999999999999.99)]
        public decimal ValorPago { get; set; }
        [MaxLength(8)]
        public string Pago { get; set; }
        public DateTime DataServico { get; set; }
        [ForeignKey("Pessoa")]
        public int PessoaId { get; set; }
        public virtual Pessoa Pessoa { get; set; }


    }
}
