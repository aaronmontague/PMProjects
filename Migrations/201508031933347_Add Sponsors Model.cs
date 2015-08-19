namespace PMProjects.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddSponsorsModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Sponsors",
                c => new
                    {
                        SponsorID = c.Int(nullable: false, identity: true),
                        SponsorName = c.String(),
                    })
                .PrimaryKey(t => t.SponsorID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Sponsors");
        }
    }
}
