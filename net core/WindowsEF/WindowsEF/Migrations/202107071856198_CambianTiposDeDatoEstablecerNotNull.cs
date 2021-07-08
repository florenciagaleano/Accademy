namespace WindowsEF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CambianTiposDeDatoEstablecerNotNull : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Producto", "Nombre", c => c.String(nullable: false, maxLength: 50, unicode: false));
            AlterColumn("dbo.Producto", "Precio", c => c.Decimal(nullable: false, storeType: "money"));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Producto", "Precio", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.Producto", "Nombre", c => c.String());
        }
    }
}
