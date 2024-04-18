namespace CapadeDatos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AdicionTablaFunciones : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Funciones",
                c => new
                    {
                        FuncionId = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 70),
                        Estado = c.Boolean(nullable: false),
                        FechaCreacion = c.DateTime(nullable: false),
                        FechaModificacion = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.FuncionId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Funciones");
        }
    }
}
