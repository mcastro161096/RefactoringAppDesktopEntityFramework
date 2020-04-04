namespace projetoTelas.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AlterandoTabelaPessoas : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Pessoas", name: "Pessoas_IdPessoa", newName: "Pessoa_IdPessoa");
            RenameIndex(table: "dbo.Pessoas", name: "IX_Pessoas_IdPessoa", newName: "IX_Pessoa_IdPessoa");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Pessoas", name: "IX_Pessoa_IdPessoa", newName: "IX_Pessoas_IdPessoa");
            RenameColumn(table: "dbo.Pessoas", name: "Pessoa_IdPessoa", newName: "Pessoas_IdPessoa");
        }
    }
}
