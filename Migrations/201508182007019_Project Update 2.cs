namespace PMProjects.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ProjectUpdate2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Projects", "StartDate", c => c.DateTime(nullable: false, storeType: "date"));
            AlterColumn("dbo.Projects", "EndDate", c => c.DateTime(storeType: "date"));
            AlterColumn("dbo.Projects", "AcutalEndDate", c => c.DateTime(storeType: "date"));
            AlterColumn("dbo.Projects", "RYGStatus", c => c.String());
            AlterColumn("dbo.Projects", "RYGSchedule", c => c.String());
            AlterColumn("dbo.Projects", "RYGScope", c => c.String());
            AlterColumn("dbo.Projects", "RYGBudget", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Projects", "RYGBudget", c => c.Int());
            AlterColumn("dbo.Projects", "RYGScope", c => c.Int());
            AlterColumn("dbo.Projects", "RYGSchedule", c => c.Int());
            AlterColumn("dbo.Projects", "RYGStatus", c => c.Int());
            AlterColumn("dbo.Projects", "AcutalEndDate", c => c.DateTime());
            AlterColumn("dbo.Projects", "EndDate", c => c.DateTime());
            AlterColumn("dbo.Projects", "StartDate", c => c.DateTime(nullable: false));
        }
    }
}
