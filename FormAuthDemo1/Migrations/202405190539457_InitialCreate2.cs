namespace FormAuthDemo1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Reservations",
                c => new
                    {
                        ReservationId = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        ReservationDate = c.DateTime(nullable: false),
                        NumberOfGuests = c.Int(nullable: false),
                        SeatingPreference = c.String(),
                        Status = c.String(),
                    })
                .PrimaryKey(t => t.ReservationId)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Reservations", "UserId", "dbo.Users");
            DropIndex("dbo.Reservations", new[] { "UserId" });
            DropTable("dbo.Reservations");
        }
    }
}
