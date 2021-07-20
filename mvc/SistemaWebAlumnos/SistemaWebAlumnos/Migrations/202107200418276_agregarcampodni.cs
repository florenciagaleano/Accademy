namespace SistemaWebAlumnos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class agregarcampodni : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Alumnoes", "DNI", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Alumnoes", "DNI");
        }
    }
}
