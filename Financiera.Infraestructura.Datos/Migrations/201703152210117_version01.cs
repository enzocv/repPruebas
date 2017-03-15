namespace Financiera.Infraestructura.Datos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class version01 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "FI.CLIENTES",
                c => new
                    {
                        COD_CLIENTE = c.Int(nullable: false, identity: true),
                        NOM_CLIENTE = c.String(nullable: false),
                        FEC_NACIMIENTO = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.COD_CLIENTE);
            
            CreateTable(
                "FI.CUENTA_AHORROS",
                c => new
                    {
                        NUM_CUENTA = c.Int(nullable: false, identity: true),
                        COD_CUENTA = c.String(nullable: false),
                        SAL_DISPONIBLE = c.Decimal(nullable: false, precision: 18, scale: 2),
                        COD_CLIENTE = c.Int(nullable: false),
                        EST_CUENTA = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.NUM_CUENTA)
                .ForeignKey("FI.CLIENTES", t => t.COD_CLIENTE, cascadeDelete: true)
                .Index(t => t.COD_CLIENTE);
            
        }
        
        public override void Down()
        {
            DropForeignKey("FI.CUENTA_AHORROS", "COD_CLIENTE", "FI.CLIENTES");
            DropIndex("FI.CUENTA_AHORROS", new[] { "COD_CLIENTE" });
            DropTable("FI.CUENTA_AHORROS");
            DropTable("FI.CLIENTES");
        }
    }
}
