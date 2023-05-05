namespace JCommerce.Infraestructura.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Entidades : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Persona",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        LocalidadId = c.Int(nullable: false),
                        Nombre = c.String(nullable: false, maxLength: 200),
                        Apellido = c.String(nullable: false, maxLength: 200),
                        Documento = c.String(nullable: false, maxLength: 8),
                        Domicilio = c.String(nullable: false, maxLength: 300),
                        Telefono = c.String(nullable: false, maxLength: 11),
                        Email = c.String(maxLength: 100),
                        FechaNacimiento = c.DateTime(nullable: false),
                        Foto = c.Binary(nullable: false),
                        EstaEliminado = c.Boolean(nullable: false),
                        RowVersion = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Localidad", t => t.LocalidadId)
                .Index(t => t.LocalidadId);
            
            CreateTable(
                "dbo.Localidad",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descripcion = c.String(),
                        ProvinciaId = c.Int(nullable: false),
                        EstaEliminado = c.Boolean(nullable: false),
                        RowVersion = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Provincia", t => t.ProvinciaId)
                .Index(t => t.ProvinciaId);
            
            CreateTable(
                "dbo.Provincia",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descripcion = c.String(nullable: false, maxLength: 200),
                        EstaEliminado = c.Boolean(nullable: false),
                        RowVersion = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                        NPais_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Pais", t => t.NPais_Id)
                .Index(t => t.NPais_Id);
            
            CreateTable(
                "dbo.Pais",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descripcion = c.String(nullable: false, maxLength: 200),
                        EstaEliminado = c.Boolean(nullable: false),
                        RowVersion = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Cliente",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Localidad_Id = c.Int(),
                        Cuil = c.Int(),
                        RazonSocial = c.String(maxLength: 200),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Persona", t => t.Id)
                .ForeignKey("dbo.Localidad", t => t.Localidad_Id)
                .Index(t => t.Id)
                .Index(t => t.Localidad_Id);
            
            CreateTable(
                "dbo.Empleado",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Localidad_Id = c.Int(),
                        Legajo = c.Int(nullable: false),
                        FechaIngreso = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Persona", t => t.Id)
                .ForeignKey("dbo.Localidad", t => t.Localidad_Id)
                .Index(t => t.Id)
                .Index(t => t.Localidad_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Empleado", "Localidad_Id", "dbo.Localidad");
            DropForeignKey("dbo.Empleado", "Id", "dbo.Persona");
            DropForeignKey("dbo.Cliente", "Localidad_Id", "dbo.Localidad");
            DropForeignKey("dbo.Cliente", "Id", "dbo.Persona");
            DropForeignKey("dbo.Persona", "LocalidadId", "dbo.Localidad");
            DropForeignKey("dbo.Provincia", "NPais_Id", "dbo.Pais");
            DropForeignKey("dbo.Localidad", "ProvinciaId", "dbo.Provincia");
            DropIndex("dbo.Empleado", new[] { "Localidad_Id" });
            DropIndex("dbo.Empleado", new[] { "Id" });
            DropIndex("dbo.Cliente", new[] { "Localidad_Id" });
            DropIndex("dbo.Cliente", new[] { "Id" });
            DropIndex("dbo.Provincia", new[] { "NPais_Id" });
            DropIndex("dbo.Localidad", new[] { "ProvinciaId" });
            DropIndex("dbo.Persona", new[] { "LocalidadId" });
            DropTable("dbo.Empleado");
            DropTable("dbo.Cliente");
            DropTable("dbo.Pais");
            DropTable("dbo.Provincia");
            DropTable("dbo.Localidad");
            DropTable("dbo.Persona");
        }
    }
}
