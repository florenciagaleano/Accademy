namespace TSQualityWebsite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class intento3 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Camions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Matricula = c.String(nullable: false, maxLength: 6),
                        Marca = c.String(nullable: false, maxLength: 50),
                        Modelo = c.Int(nullable: false),
                        Chofer_Id = c.Int(),
                        IdChofer_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Chofers", t => t.Chofer_Id)
                .ForeignKey("dbo.Chofers", t => t.IdChofer_Id)
                .Index(t => t.Chofer_Id)
                .Index(t => t.IdChofer_Id);
            
            CreateTable(
                "dbo.Chofers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Dni = c.String(nullable: false, maxLength: 12),
                        Email = c.String(nullable: false, maxLength: 100),
                        Nacimiento = c.DateTime(nullable: false),
                        CamionId_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Camions", t => t.CamionId_Id)
                .Index(t => t.CamionId_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Camions", "IdChofer_Id", "dbo.Chofers");
            DropForeignKey("dbo.Camions", "Chofer_Id", "dbo.Chofers");
            DropForeignKey("dbo.Chofers", "CamionId_Id", "dbo.Camions");
            DropIndex("dbo.Chofers", new[] { "CamionId_Id" });
            DropIndex("dbo.Camions", new[] { "IdChofer_Id" });
            DropIndex("dbo.Camions", new[] { "Chofer_Id" });
            DropTable("dbo.Chofers");
            DropTable("dbo.Camions");
        }
    }
}
