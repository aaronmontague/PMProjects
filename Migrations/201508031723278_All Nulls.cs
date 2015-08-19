namespace PMProjects.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AllNulls : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Projects", "EndDate", c => c.DateTime());
            AlterColumn("dbo.Projects", "AcutalEndDate", c => c.DateTime());
            AlterColumn("dbo.Projects", "CHGnumber", c => c.Int());
            AlterColumn("dbo.Projects", "RYGStatus", c => c.Int());
            AlterColumn("dbo.Projects", "RYGSchedule", c => c.Int());
            AlterColumn("dbo.Projects", "RYGScope", c => c.Int());
            AlterColumn("dbo.Projects", "RYGBudget", c => c.Int());
            AlterColumn("dbo.Projects", "ProjectLevelOfRisk", c => c.Int());
            AlterColumn("dbo.Projects", "ProjectInitialBudget", c => c.Double());
            AlterColumn("dbo.Projects", "ITSLead", c => c.Int());
            AlterColumn("dbo.Projects", "ITSProjectManageer", c => c.Int());
            AlterColumn("dbo.Projects", "SVPSponsor", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Projects", "SVPSponsor", c => c.Int(nullable: false));
            AlterColumn("dbo.Projects", "ITSProjectManageer", c => c.Int(nullable: false));
            AlterColumn("dbo.Projects", "ITSLead", c => c.Int(nullable: false));
            AlterColumn("dbo.Projects", "ProjectInitialBudget", c => c.Double(nullable: false));
            AlterColumn("dbo.Projects", "ProjectLevelOfRisk", c => c.Int(nullable: false));
            AlterColumn("dbo.Projects", "RYGBudget", c => c.Int(nullable: false));
            AlterColumn("dbo.Projects", "RYGScope", c => c.Int(nullable: false));
            AlterColumn("dbo.Projects", "RYGSchedule", c => c.Int(nullable: false));
            AlterColumn("dbo.Projects", "RYGStatus", c => c.Int(nullable: false));
            AlterColumn("dbo.Projects", "CHGnumber", c => c.Int(nullable: false));
            AlterColumn("dbo.Projects", "AcutalEndDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Projects", "EndDate", c => c.DateTime(nullable: false));
        }
    }
}
