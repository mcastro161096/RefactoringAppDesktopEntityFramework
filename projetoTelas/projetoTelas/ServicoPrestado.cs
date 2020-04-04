using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace projetoTelas
{[Table("ServicosPrestados")]
    public class ServicoPrestado
    {
        public int IdServico { get; set; }
        public string DescricaoServico { get; set; }
        public decimal ValorTotal { get; set; }
        public decimal ValorPago { get; set; }
        public string Pago { get; set; }
        public DateTime DataServico { get; set; }
        [ForeignKey(nameof(Pessoa))]
        public int PessoaId { get; set; }
        public virtual Pessoa Pessoa { get; set; }


    }
}
