namespace WebSiteProductos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class actualizacion : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Product", new[] { "SubCategoryID" });
            CreateIndex("dbo.Product", "SubcategoryID");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Product", new[] { "SubcategoryID" });
            CreateIndex("dbo.Product", "SubCategoryID");
        }
    }
}
