namespace PMProjects.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PartAResourceUpdate2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.PartAResources", "InitialCost", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.PartAResources", "RecurringCost", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.PartAResources", "RecurringCost", c => c.Double(nullable: false));
            AlterColumn("dbo.PartAResources", "InitialCost", c => c.Double(nullable: false));
        }
    }
}
