namespace PMProjects.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class partAupdate : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Projects", "ProjectDescription", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Projects", "ProjectDescription", c => c.String());
        }
    }
}
