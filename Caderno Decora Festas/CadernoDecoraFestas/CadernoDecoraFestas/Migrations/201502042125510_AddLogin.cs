namespace CadernoDecoraFestas.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddLogin : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Fornecedores", "Login", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Fornecedores", "Login");
        }
    }
}
