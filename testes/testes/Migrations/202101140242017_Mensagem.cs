namespace testes.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Mensagem : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Mensagem",
                c => new
                    {
                        MensagemID = c.Int(nullable: false, identity: true),
                        MensagemConteudo = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.MensagemID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Mensagem");
        }
    }
}
