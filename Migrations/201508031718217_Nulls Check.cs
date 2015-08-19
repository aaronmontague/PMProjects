namespace PMProjects.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NullsCheck : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Projects", "ProjectSizingScore", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Projects", "ProjectSizingScore", c => c.Int(nullable: false));
        }
    }
}
