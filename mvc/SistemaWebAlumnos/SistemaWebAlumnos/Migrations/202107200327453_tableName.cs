namespace SistemaWebAlumnos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tableName : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Alumnoes", newName: "Alumno");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Alumno", newName: "Alumnoes");
        }
    }
}
