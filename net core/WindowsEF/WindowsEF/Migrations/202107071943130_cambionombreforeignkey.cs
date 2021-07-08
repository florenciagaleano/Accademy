namespace WindowsEF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class cambionombreforeignkey : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Producto", "Categoria_Id", "dbo.Categoria");
            DropIndex("dbo.Producto", new[] { "Categoria_Id" });
            RenameColumn(table: "dbo.Producto", name: "Categoria_Id", newName: "CategoriaID");
            AlterColumn("dbo.Producto", "CategoriaID", c => c.Int(nullable: false));
            CreateIndex("dbo.Producto", "CategoriaID");
            AddForeignKey("dbo.Producto", "CategoriaID", "dbo.Categoria", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Producto", "CategoriaID", "dbo.Categoria");
            DropIndex("dbo.Producto", new[] { "CategoriaID" });
            AlterColumn("dbo.Producto", "CategoriaID", c => c.Int());
            RenameColumn(table: "dbo.Producto", name: "CategoriaID", newName: "Categoria_Id");
            CreateIndex("dbo.Producto", "Categoria_Id");
            AddForeignKey("dbo.Producto", "Categoria_Id", "dbo.Categoria", "Id");
        }
    }
}
