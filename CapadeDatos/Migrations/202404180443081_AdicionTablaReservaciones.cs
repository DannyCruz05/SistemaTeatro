namespace CapadeDatos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AdicionTablaReservaciones : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Reservaciones",
                c => new
                    {
                        ReservacionId = c.Int(nullable: false, identity: true),
                        ClienteId = c.Int(nullable: false),
                        FuncionesId = c.Int(nullable: false),
                        Asiento = c.String(nullable: false),
                        FechaCreacion = c.DateTime(nullable: false),
                        PagoReserva = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Estado = c.Boolean(nullable: false),
                        FechaModificacion = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ReservacionId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Reservaciones");
        }
    }
}
