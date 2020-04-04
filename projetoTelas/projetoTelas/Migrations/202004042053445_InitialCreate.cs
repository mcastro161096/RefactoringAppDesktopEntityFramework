namespace projetoTelas.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Pessoas",
                c => new
                    {
                        IdPessoa = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Telefone = c.String(),
                        PlacaVeiculo = c.String(),
                        Pessoas_IdPessoa = c.Int(),
                    })
                .PrimaryKey(t => t.IdPessoa)
                .ForeignKey("dbo.Pessoas", t => t.Pessoas_IdPessoa)
                .Index(t => t.Pessoas_IdPessoa);
            
            CreateTable(
                "dbo.ServicosPrestados",
                c => new
                    {
                        IdServico = c.Int(nullable: false, identity: true),
                        DescricaoServico = c.String(),
                        ValorTotal = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ValorPago = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Pago = c.String(),
                        DataServico = c.DateTime(nullable: false),
                        PessoaId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IdServico)
                .ForeignKey("dbo.Pessoas", t => t.PessoaId, cascadeDelete: true)
                .Index(t => t.PessoaId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ServicosPrestados", "PessoaId", "dbo.Pessoas");
            DropForeignKey("dbo.Pessoas", "Pessoas_IdPessoa", "dbo.Pessoas");
            DropIndex("dbo.ServicosPrestados", new[] { "PessoaId" });
            DropIndex("dbo.Pessoas", new[] { "Pessoas_IdPessoa" });
            DropTable("dbo.ServicosPrestados");
            DropTable("dbo.Pessoas");
        }
    }
}
