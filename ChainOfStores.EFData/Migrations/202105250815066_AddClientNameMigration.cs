namespace ChainOfStores.EFData.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddClientNameMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Bookings",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DataOfBooking = c.DateTime(nullable: false),
                        ProductID = c.Int(nullable: false),
                        ClientName = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Products", t => t.ProductID, cascadeDelete: true)
                .Index(t => t.ProductID);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProductTypeId = c.Int(nullable: false),
                        StoreId = c.Int(nullable: false),
                        Price = c.Int(nullable: false),
                        DateOfProducing = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ProductTypes", t => t.ProductTypeId, cascadeDelete: true)
                .ForeignKey("dbo.Stores", t => t.StoreId, cascadeDelete: true)
                .Index(t => t.ProductTypeId)
                .Index(t => t.StoreId);
            
            CreateTable(
                "dbo.ProductTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ExpirationDate = c.Int(nullable: false),
                        Name = c.String(),
                        PriceRecomendation = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Stores",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Country = c.String(),
                        City = c.String(),
                        Address = c.String(),
                        ContactNumber = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Bookings", "ProductID", "dbo.Products");
            DropForeignKey("dbo.Products", "StoreId", "dbo.Stores");
            DropForeignKey("dbo.Products", "ProductTypeId", "dbo.ProductTypes");
            DropIndex("dbo.Products", new[] { "StoreId" });
            DropIndex("dbo.Products", new[] { "ProductTypeId" });
            DropIndex("dbo.Bookings", new[] { "ProductID" });
            DropTable("dbo.Stores");
            DropTable("dbo.ProductTypes");
            DropTable("dbo.Products");
            DropTable("dbo.Bookings");
        }
    }
}
