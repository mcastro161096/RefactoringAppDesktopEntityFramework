using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoTelas
{
    public class PessoaServiçoPrestado
    {
        public int id { get; set; }
        public string DescricaoReduzida { get; set; } 
        public string DescricaoCompleta { get; set; } 
        public DateTime DataServico { get; set; } 
    }
}