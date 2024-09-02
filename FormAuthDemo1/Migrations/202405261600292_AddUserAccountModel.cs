namespace FormAuthDemo1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddUserAccountModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Menus",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Reservations",
                c => new
                    {
                        ReservationID = c.Int(nullable: false, identity: true),
                        ReservationName = c.String(),
                        NoOfGuests = c.Int(nullable: false),
                        Remarks = c.String(),
                        SeatingPreference = c.String(),
                        ReservationDate = c.String(),
                        ReservationTime = c.String(),
                    })
                .PrimaryKey(t => t.ReservationID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Reservations");
            DropTable("dbo.Menus");
        }
    }
}
