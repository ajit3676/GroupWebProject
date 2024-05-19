namespace FormAuthDemo1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial2 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Employees", "Position");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Employees", "Position", c => c.String());
        }
    }
}
