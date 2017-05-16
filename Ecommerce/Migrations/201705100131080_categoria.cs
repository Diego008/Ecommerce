namespace Ecommerce.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class categoria : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categoria",
                c => new
                    {
                        CategoriaID = c.Int(nullable: false, identity: true),
                        Nome = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.CategoriaID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Categoria");
        }
    }
}
