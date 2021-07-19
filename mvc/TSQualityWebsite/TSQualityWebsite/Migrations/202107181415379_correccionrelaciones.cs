namespace TSQualityWebsite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class correccionrelaciones : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Camions", "Chofer_Id", "dbo.Chofers");
            DropForeignKey("dbo.Camions", "IdChofer_Id", "dbo.Chofers");
            DropForeignKey("dbo.Chofers", "CamionId_Id", "dbo.Camions");
            DropIndex("dbo.Camions", new[] { "Chofer_Id" });
            DropIndex("dbo.Camions", new[] { "IdChofer_Id" });
            DropIndex("dbo.Chofers", new[] { "CamionId_Id" });
            RenameColumn(table: "dbo.Chofers", name: "CamionId_Id", newName: "CamionId");
            AddColumn("dbo.Camions", "ChoferId", c => c.Int(nullable: false));
            AlterColumn("dbo.Chofers", "CamionId", c => c.Int(nullable: false));
            CreateIndex("dbo.Chofers", "CamionId");
            AddForeignKey("dbo.Chofers", "CamionId", "dbo.Camions", "Id", cascadeDelete: true);
            DropColumn("dbo.Camions", "Chofer_Id");
            DropColumn("dbo.Camions", "IdChofer_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Camions", "IdChofer_Id", c => c.Int());
            AddColumn("dbo.Camions", "Chofer_Id", c => c.Int());
            DropForeignKey("dbo.Chofers", "CamionId", "dbo.Camions");
            DropIndex("dbo.Chofers", new[] { "CamionId" });
            AlterColumn("dbo.Chofers", "CamionId", c => c.Int());
            DropColumn("dbo.Camions", "ChoferId");
            RenameColumn(table: "dbo.Chofers", name: "CamionId", newName: "CamionId_Id");
            CreateIndex("dbo.Chofers", "CamionId_Id");
            CreateIndex("dbo.Camions", "IdChofer_Id");
            CreateIndex("dbo.Camions", "Chofer_Id");
            AddForeignKey("dbo.Chofers", "CamionId_Id", "dbo.Camions", "Id");
            AddForeignKey("dbo.Camions", "IdChofer_Id", "dbo.Chofers", "Id");
            AddForeignKey("dbo.Camions", "Chofer_Id", "dbo.Chofers", "Id");
        }
    }
}
