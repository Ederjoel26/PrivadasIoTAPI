namespace PrivadasIoT.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migracion1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Casas",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        UsuarioID = c.Int(nullable: false),
                        PrivadaID = c.Int(nullable: false),
                        Estatus = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Privadas", t => t.PrivadaID, cascadeDelete: true)
                .Index(t => t.PrivadaID);
            
            CreateTable(
                "dbo.Privadas",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        NumeroSerie = c.String(),
                        Contraseña = c.String(),
                        NombreAdministrador = c.String(),
                        ContraseñaAdministrador = c.String(),
                        Estatus = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Historials",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        NumCasa = c.Int(nullable: false),
                        Obersvacion = c.String(),
                        Usuario = c.String(),
                        FechaEpoch = c.String(),
                        PrivadaID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Privadas", t => t.PrivadaID, cascadeDelete: true)
                .Index(t => t.PrivadaID);
            
            CreateTable(
                "dbo.Usuarios",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Correo = c.String(),
                        CasaID = c.Int(nullable: false),
                        Estatus = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Casas", t => t.CasaID, cascadeDelete: true)
                .Index(t => t.CasaID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Usuarios", "CasaID", "dbo.Casas");
            DropForeignKey("dbo.Historials", "PrivadaID", "dbo.Privadas");
            DropForeignKey("dbo.Casas", "PrivadaID", "dbo.Privadas");
            DropIndex("dbo.Usuarios", new[] { "CasaID" });
            DropIndex("dbo.Historials", new[] { "PrivadaID" });
            DropIndex("dbo.Casas", new[] { "PrivadaID" });
            DropTable("dbo.Usuarios");
            DropTable("dbo.Historials");
            DropTable("dbo.Privadas");
            DropTable("dbo.Casas");
        }
    }
}
