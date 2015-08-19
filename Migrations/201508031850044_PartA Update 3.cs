namespace PMProjects.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PartAUpdate3 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.PartAs", "DesiredDateComplete", c => c.DateTime(nullable: false, storeType: "date"));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.PartAs", "DesiredDateComplete", c => c.DateTime(nullable: false));
        }
    }
}
