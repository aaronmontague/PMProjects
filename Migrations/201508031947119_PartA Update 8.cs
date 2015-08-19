namespace PMProjects.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PartAUpdate8 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.PartAs", "SponsoringVP_SponsorID", "dbo.Sponsors");
            DropIndex("dbo.PartAs", new[] { "SponsoringVP_SponsorID" });
            RenameColumn(table: "dbo.PartAs", name: "SponsoringVP_SponsorID", newName: "SponsorID");
            AlterColumn("dbo.PartAs", "SponsorID", c => c.Int(nullable: false));
            CreateIndex("dbo.PartAs", "SponsorID");
            AddForeignKey("dbo.PartAs", "SponsorID", "dbo.Sponsors", "SponsorID", cascadeDelete: true);
            DropColumn("dbo.PartAs", "Sponsor");
        }
        
        public override void Down()
        {
            AddColumn("dbo.PartAs", "Sponsor", c => c.Int(nullable: false));
            DropForeignKey("dbo.PartAs", "SponsorID", "dbo.Sponsors");
            DropIndex("dbo.PartAs", new[] { "SponsorID" });
            AlterColumn("dbo.PartAs", "SponsorID", c => c.Int(defaultValue: 1));
            RenameColumn(table: "dbo.PartAs", name: "SponsorID", newName: "SponsoringVP_SponsorID");
            CreateIndex("dbo.PartAs", "SponsoringVP_SponsorID");
            AddForeignKey("dbo.PartAs", "SponsoringVP_SponsorID", "dbo.Sponsors", "SponsorID");
        }
    }
}
