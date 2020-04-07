namespace projetoTelas.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SetandoTamanhosCampos : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Pessoas", "Nome", c => c.String(maxLength: 150));
            AlterColumn("dbo.Pessoas", "Telefone", c => c.String(maxLength: 15));
            AlterColumn("dbo.Pessoas", "PlacaVeiculo", c => c.String(maxLength: 8));
            AlterColumn("dbo.ServicosPrestados", "DescricaoServico", c => c.String(maxLength: 2000));
            AlterColumn("dbo.ServicosPrestados", "Pago", c => c.String(maxLength: 8));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.ServicosPrestados", "Pago", c => c.String());
            AlterColumn("dbo.ServicosPrestados", "DescricaoServico", c => c.String());
            AlterColumn("dbo.Pessoas", "PlacaVeiculo", c => c.String());
            AlterColumn("dbo.Pessoas", "Telefone", c => c.String());
            AlterColumn("dbo.Pessoas", "Nome", c => c.String());
        }
    }
}
