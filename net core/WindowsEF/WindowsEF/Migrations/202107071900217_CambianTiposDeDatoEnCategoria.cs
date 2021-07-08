namespace WindowsEF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CambianTiposDeDatoEnCategoria : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Categoria", "Nombre", c => c.String(nullable: false, maxLength: 50, unicode: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Categoria", "Nombre", c => c.String());
        }
    }
}
