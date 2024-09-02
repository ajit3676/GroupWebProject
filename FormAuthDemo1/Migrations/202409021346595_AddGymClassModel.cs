namespace FormAuthDemo1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddGymClassModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.GymClasses",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        Schedule = c.DateTime(nullable: false),
                        Instructor = c.String(),
                        Duration = c.Int(nullable: false),
                        Capacity = c.Int(nullable: false),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.GymClasses");
        }
    }
}
