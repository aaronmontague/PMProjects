namespace PMProjects.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PartAPopulationAffectedUpdate2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.PartAPopulationAffecteds", "ImpactLevel", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.PartAPopulationAffecteds", "ImpactLevel", c => c.Int(nullable: false));
        }
    }
}
