namespace WindowsEF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class agregarfechanacimiento : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Empleado", "FechaNacimiento", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Empleado", "FechaNacimiento");
        }
    }
}
