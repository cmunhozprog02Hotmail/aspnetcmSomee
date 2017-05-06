namespace aspnetcmSomee.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Contato",
                c => new
                    {
                        ContatoId = c.Int(nullable: false, identity: true),
                        Nome = c.String(maxLength: 100, unicode: false),
                    })
                .PrimaryKey(t => t.ContatoId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Contato");
        }
    }
}
