namespace WebSiteProductos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        CategoryID = c.Int(nullable: false, identity: true),
                        CategoryName = c.String(nullable: false, maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => t.CategoryID);
            
            CreateTable(
                "dbo.Subcategory",
                c => new
                    {
                        SubcategoryID = c.Int(nullable: false, identity: true),
                        SubcategoryName = c.String(nullable: false, maxLength: 50, unicode: false),
                        CategoryID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.SubcategoryID)
                .ForeignKey("dbo.Categories", t => t.CategoryID, cascadeDelete: true)
                .Index(t => t.CategoryID);
            
            CreateTable(
                "dbo.Product",
                c => new
                    {
                        ProductId = c.Int(nullable: false, identity: true),
                        ProductName = c.String(nullable: false, maxLength: 50, unicode: false),
                        ProductNumber = c.String(nullable: false, maxLength: 50, unicode: false),
                        Color = c.String(nullable: false, maxLength: 50, unicode: false),
                        DaysToManuFacture = c.Int(nullable: false),
                        SellStartDate = c.DateTime(nullable: false, storeType: "date"),
                        SellEndDate = c.DateTime(nullable: false, storeType: "date"),
                        Size = c.String(maxLength: 50, unicode: false),
                        ListPrice = c.Decimal(nullable: false, storeType: "money"),
                        SubCategoryID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ProductId)
                .ForeignKey("dbo.Subcategory", t => t.SubCategoryID, cascadeDelete: true)
                .Index(t => t.SubCategoryID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Product", "SubCategoryID", "dbo.Subcategory");
            DropForeignKey("dbo.Subcategory", "CategoryID", "dbo.Categories");
            DropIndex("dbo.Product", new[] { "SubCategoryID" });
            DropIndex("dbo.Subcategory", new[] { "CategoryID" });
            DropTable("dbo.Product");
            DropTable("dbo.Subcategory");
            DropTable("dbo.Categories");
        }
    }
}
