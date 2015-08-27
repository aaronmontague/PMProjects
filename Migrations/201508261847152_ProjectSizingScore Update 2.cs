namespace PMProjects.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ProjectSizingScoreUpdate2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ProjectSizingWorksheets", "ProjectSizingScore", c => c.Int());
        }
        
        public override void Down()
        {
            DropColumn("dbo.ProjectSizingWorksheets", "ProjectSizingScore");
        }
    }
}
