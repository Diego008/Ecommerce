namespace Ecommerce.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Usuario3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Usuario", "Contato", c => c.String(nullable: false, unicode: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Usuario", "Contato");
        }
    }
}
