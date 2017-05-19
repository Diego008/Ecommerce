namespace Ecommerce.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Admin1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Admin",
                c => new
                    {
                        AdminId = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, unicode: false),
                        Email = c.String(nullable: false, unicode: false),
                        Senha = c.String(nullable: false, maxLength: 100, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.AdminId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Admin");
        }
    }
}
