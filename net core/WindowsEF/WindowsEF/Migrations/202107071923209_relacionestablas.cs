namespace WindowsEF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class relacionestablas : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Producto", "Categoria_Id", c => c.Int());
            CreateIndex("dbo.Producto", "Categoria_Id");
            AddForeignKey("dbo.Producto", "Categoria_Id", "dbo.Categoria", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Producto", "Categoria_Id", "dbo.Categoria");
            DropIndex("dbo.Producto", new[] { "Categoria_Id" });
            DropColumn("dbo.Producto", "Categoria_Id");
        }
    }
}
