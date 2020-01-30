using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoTelas
{
    class Context : DbContext
    {

        public Context(): base("dbProjetoTelas")
        {
            Database.SetInitializer<Context>(
               new CreateDatabaseIfNotExists<Context>());
           
        }

        public DbSet<Pessoa> Pessoas { get; set; }
        public DbSet<PessoaServiçoPrestado> PessoaServicosPrestados { get; set; }
    }
}
