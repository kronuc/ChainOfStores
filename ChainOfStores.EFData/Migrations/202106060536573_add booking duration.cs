namespace ChainOfStores.EFData.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addbookingduration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BookingDurations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AmountOfDays = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.BookingDurations");
        }
    }
}
