namespace CadernoDecoraFestas.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddFone1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Fornecedores", "Fone1", c => c.String(nullable: false, maxLength: 9));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Fornecedores", "Fone1");
        }
    }
}
