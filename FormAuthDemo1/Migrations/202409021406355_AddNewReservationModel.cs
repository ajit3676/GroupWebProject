namespace FormAuthDemo1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNewReservationModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.NewReservations",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        UserID = c.Int(nullable: false),
                        GymClassID = c.Int(nullable: false),
                        ReservationDate = c.DateTime(nullable: false),
                        IsCancelled = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.NewReservations");
        }
    }
}
