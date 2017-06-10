namespace Ecommerce.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Usuario2 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Usuario", "Contato");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Usuario", "Contato", c => c.String(nullable: false, unicode: false));
        }
    }
}
