namespace Ecommerce.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Usuario : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Usuario",
                c => new
                    {
                        UsuarioID = c.Int(nullable: false, identity: true),
                        Nome = c.String(unicode: false),
                        Cpf = c.String(unicode: false),
                        Rg = c.String(unicode: false),
                        Cep = c.String(unicode: false),
                        Endereco = c.String(unicode: false),
                        Numero = c.String(unicode: false),
                        Bairro = c.String(unicode: false),
                        Cidade = c.String(unicode: false),
                        Contato = c.String(unicode: false),
                        Email = c.String(unicode: false),
                        Senha = c.String(unicode: false),
                        Imagem = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.UsuarioID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Usuario");
        }
    }
}
