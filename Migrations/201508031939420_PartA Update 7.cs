namespace PMProjects.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PartAUpdate7 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.PartAs", "SponsoringVP_SponsorID", c => c.Int());
            CreateIndex("dbo.PartAs", "SponsoringVP_SponsorID");
            AddForeignKey("dbo.PartAs", "SponsoringVP_SponsorID", "dbo.Sponsors", "SponsorID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PartAs", "SponsoringVP_SponsorID", "dbo.Sponsors");
            DropIndex("dbo.PartAs", new[] { "SponsoringVP_SponsorID" });
            DropColumn("dbo.PartAs", "SponsoringVP_SponsorID");
        }
    }
}
