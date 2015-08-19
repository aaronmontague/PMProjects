namespace PMProjects.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ProjectUpdate : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Projects", "ITSLead", c => c.String());
            AlterColumn("dbo.Projects", "ITSProjectManageer", c => c.String());
            AlterColumn("dbo.Projects", "SVPSponsor", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Projects", "SVPSponsor", c => c.Int());
            AlterColumn("dbo.Projects", "ITSProjectManageer", c => c.Int());
            AlterColumn("dbo.Projects", "ITSLead", c => c.Int());
        }
    }
}
