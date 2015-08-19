namespace PMProjects.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PartAApplicatonAffectedUpdate1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.PartAApplicationAffecteds", "CertaintyOfAffect", c => c.String());
            AlterColumn("dbo.PartAApplicationAffecteds", "ImpactOfAffect", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.PartAApplicationAffecteds", "ImpactOfAffect", c => c.Int(nullable: false));
            AlterColumn("dbo.PartAApplicationAffecteds", "CertaintyOfAffect", c => c.Int(nullable: false));
        }
    }
}
