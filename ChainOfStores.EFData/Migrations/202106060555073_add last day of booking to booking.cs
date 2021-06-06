namespace ChainOfStores.EFData.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addlastdayofbookingtobooking : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Bookings", "LastDayOfBooking", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Bookings", "LastDayOfBooking");
        }
    }
}
