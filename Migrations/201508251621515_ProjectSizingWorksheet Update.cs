namespace PMProjects.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ProjectSizingWorksheetUpdate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ProjectSizingWorksheets", "Question1Value", c => c.Int());
            AddColumn("dbo.ProjectSizingWorksheets", "Question2Value", c => c.Int());
            AddColumn("dbo.ProjectSizingWorksheets", "Question3Value", c => c.Int());
            AddColumn("dbo.ProjectSizingWorksheets", "Question4Value", c => c.Int());
            AddColumn("dbo.ProjectSizingWorksheets", "Question5Value", c => c.Int());
            AddColumn("dbo.ProjectSizingWorksheets", "Question6Value", c => c.Int());
            AddColumn("dbo.ProjectSizingWorksheets", "Question7Value", c => c.Int());
            AddColumn("dbo.ProjectSizingWorksheets", "Question8Value", c => c.Int());
            AddColumn("dbo.ProjectSizingWorksheets", "Question9Value", c => c.Int());
            AddColumn("dbo.ProjectSizingWorksheets", "Question10Value", c => c.Int());
        }
        
        public override void Down()
        {
            DropColumn("dbo.ProjectSizingWorksheets", "Question10Value");
            DropColumn("dbo.ProjectSizingWorksheets", "Question9Value");
            DropColumn("dbo.ProjectSizingWorksheets", "Question8Value");
            DropColumn("dbo.ProjectSizingWorksheets", "Question7Value");
            DropColumn("dbo.ProjectSizingWorksheets", "Question6Value");
            DropColumn("dbo.ProjectSizingWorksheets", "Question5Value");
            DropColumn("dbo.ProjectSizingWorksheets", "Question4Value");
            DropColumn("dbo.ProjectSizingWorksheets", "Question3Value");
            DropColumn("dbo.ProjectSizingWorksheets", "Question2Value");
            DropColumn("dbo.ProjectSizingWorksheets", "Question1Value");
        }
    }
}
