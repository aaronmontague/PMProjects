namespace PMProjects.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PartAApplicationAffecteds",
                c => new
                    {
                        PartAApplicationAffectedID = c.Int(nullable: false, identity: true),
                        PartAID = c.Int(nullable: false),
                        ApplicationName = c.String(),
                        CertaintyOfAffect = c.Int(nullable: false),
                        ImpactOfAffect = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PartAApplicationAffectedID)
                .ForeignKey("dbo.PartAs", t => t.PartAID, cascadeDelete: true)
                .Index(t => t.PartAID);
            
            CreateTable(
                "dbo.PartAPopulationAffecteds",
                c => new
                    {
                        PartAPopulationAffectedID = c.Int(nullable: false, identity: true),
                        PartAID = c.Int(nullable: false),
                        PopulationName = c.String(),
                        SpecificImpact = c.String(),
                        ImpactLevel = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PartAPopulationAffectedID)
                .ForeignKey("dbo.PartAs", t => t.PartAID, cascadeDelete: true)
                .Index(t => t.PartAID);
            
            CreateTable(
                "dbo.PartAResources",
                c => new
                    {
                        PartAResourceID = c.Int(nullable: false, identity: true),
                        PartAID = c.Int(nullable: false),
                        ResourceName = c.String(),
                        InitialCost = c.Double(nullable: false),
                        RecurringCost = c.Double(nullable: false),
                        FundingSource = c.String(),
                    })
                .PrimaryKey(t => t.PartAResourceID)
                .ForeignKey("dbo.PartAs", t => t.PartAID, cascadeDelete: true)
                .Index(t => t.PartAID);
            
            CreateTable(
                "dbo.PartAs",
                c => new
                    {
                        PartAID = c.Int(nullable: false, identity: true),
                        ProjectID = c.Int(nullable: false),
                        ProposalTitle = c.String(),
                        ProposalNumber = c.Int(nullable: false),
                        Sponsor = c.Int(nullable: false),
                        PrimaryContact = c.String(),
                        DesiredDateComplete = c.DateTime(nullable: false),
                        SVPApproved = c.Boolean(nullable: false),
                        LongerThanTwoWeeks = c.Boolean(nullable: false),
                        ProjectOverview = c.String(),
                        BusinessCase = c.String(),
                        CoreInterfaces = c.String(),
                        BusinessRisks = c.String(),
                    })
                .PrimaryKey(t => t.PartAID)
                .ForeignKey("dbo.Projects", t => t.ProjectID, cascadeDelete: true)
                .Index(t => t.ProjectID);
            
            CreateTable(
                "dbo.Projects",
                c => new
                    {
                        ProjectID = c.Int(nullable: false, identity: true),
                        ProjectName = c.String(),
                        ProjectSizingScore = c.Int(nullable: false),
                        StartDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(nullable: false),
                        AcutalEndDate = c.DateTime(nullable: false),
                        CHGnumber = c.Int(nullable: false),
                        ProjectDescription = c.String(),
                        ProjectStatus = c.String(),
                        ProjectCurrentPhase = c.String(),
                        RYGStatus = c.Int(nullable: false),
                        RYGSchedule = c.Int(nullable: false),
                        RYGScope = c.Int(nullable: false),
                        RYGBudget = c.Int(nullable: false),
                        ProjectLevelOfRisk = c.Int(nullable: false),
                        UpComingMilestones = c.String(),
                        KeyIssuesRisks = c.String(),
                        ProjectInitialBudget = c.Double(nullable: false),
                        ITSLead = c.Int(nullable: false),
                        ITSProjectManageer = c.Int(nullable: false),
                        SVPSponsor = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ProjectID);
            
            CreateTable(
                "dbo.BudgetPlans",
                c => new
                    {
                        BudgetPlanID = c.Int(nullable: false, identity: true),
                        ProjectID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.BudgetPlanID)
                .ForeignKey("dbo.Projects", t => t.ProjectID, cascadeDelete: true)
                .Index(t => t.ProjectID);
            
            CreateTable(
                "dbo.BusinessRequirements",
                c => new
                    {
                        BusinessRequirementID = c.Int(nullable: false, identity: true),
                        ProjectID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.BusinessRequirementID)
                .ForeignKey("dbo.Projects", t => t.ProjectID, cascadeDelete: true)
                .Index(t => t.ProjectID);
            
            CreateTable(
                "dbo.CloseOutChecklists",
                c => new
                    {
                        CloseOutChecklistID = c.Int(nullable: false, identity: true),
                        ProjectID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CloseOutChecklistID)
                .ForeignKey("dbo.Projects", t => t.ProjectID, cascadeDelete: true)
                .Index(t => t.ProjectID);
            
            CreateTable(
                "dbo.CustomerAcceptances",
                c => new
                    {
                        CustomerAcceptanceID = c.Int(nullable: false, identity: true),
                        ProjectID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CustomerAcceptanceID)
                .ForeignKey("dbo.Projects", t => t.ProjectID, cascadeDelete: true)
                .Index(t => t.ProjectID);
            
            CreateTable(
                "dbo.DecisionLogs",
                c => new
                    {
                        DecisionLogID = c.Int(nullable: false, identity: true),
                        ProjectID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.DecisionLogID)
                .ForeignKey("dbo.Projects", t => t.ProjectID, cascadeDelete: true)
                .Index(t => t.ProjectID);
            
            CreateTable(
                "dbo.DevelopUATTestPlanandUseCases",
                c => new
                    {
                        DevelopUATTestPlanandUseCasesID = c.Int(nullable: false, identity: true),
                        ProjectID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.DevelopUATTestPlanandUseCasesID)
                .ForeignKey("dbo.Projects", t => t.ProjectID, cascadeDelete: true)
                .Index(t => t.ProjectID);
            
            CreateTable(
                "dbo.ExecuteUATtestPlanandUseCases",
                c => new
                    {
                        ExecuteUATtestPlanandUseCasesID = c.Int(nullable: false, identity: true),
                        ProjectID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ExecuteUATtestPlanandUseCasesID)
                .ForeignKey("dbo.Projects", t => t.ProjectID, cascadeDelete: true)
                .Index(t => t.ProjectID);
            
            CreateTable(
                "dbo.ImplemenationPlans",
                c => new
                    {
                        ImplemenationPlanID = c.Int(nullable: false, identity: true),
                        ProjectID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ImplemenationPlanID)
                .ForeignKey("dbo.Projects", t => t.ProjectID, cascadeDelete: true)
                .Index(t => t.ProjectID);
            
            CreateTable(
                "dbo.InitialCommunivcationsPlans",
                c => new
                    {
                        InitialCommunivcationsPlanID = c.Int(nullable: false, identity: true),
                        ProjectID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.InitialCommunivcationsPlanID)
                .ForeignKey("dbo.Projects", t => t.ProjectID, cascadeDelete: true)
                .Index(t => t.ProjectID);
            
            CreateTable(
                "dbo.InitialProjectPlans",
                c => new
                    {
                        InitialProjectPlanID = c.Int(nullable: false, identity: true),
                        ProjectID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.InitialProjectPlanID)
                .ForeignKey("dbo.Projects", t => t.ProjectID, cascadeDelete: true)
                .Index(t => t.ProjectID);
            
            CreateTable(
                "dbo.InitialSupportPlans",
                c => new
                    {
                        InitialSupportPlanID = c.Int(nullable: false, identity: true),
                        ProjectID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.InitialSupportPlanID)
                .ForeignKey("dbo.Projects", t => t.ProjectID, cascadeDelete: true)
                .Index(t => t.ProjectID);
            
            CreateTable(
                "dbo.InitialTrainingPlans",
                c => new
                    {
                        InitialTrainingPlanID = c.Int(nullable: false, identity: true),
                        ProjectID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.InitialTrainingPlanID)
                .ForeignKey("dbo.Projects", t => t.ProjectID, cascadeDelete: true)
                .Index(t => t.ProjectID);
            
            CreateTable(
                "dbo.LessonsLearneds",
                c => new
                    {
                        LessonsLearnedID = c.Int(nullable: false, identity: true),
                        ProjectID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.LessonsLearnedID)
                .ForeignKey("dbo.Projects", t => t.ProjectID, cascadeDelete: true)
                .Index(t => t.ProjectID);
            
            CreateTable(
                "dbo.PartBs",
                c => new
                    {
                        PartBID = c.Int(nullable: false, identity: true),
                        ProjectID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PartBID)
                .ForeignKey("dbo.Projects", t => t.ProjectID, cascadeDelete: true)
                .Index(t => t.ProjectID);
            
            CreateTable(
                "dbo.Performancetestings",
                c => new
                    {
                        PerformancetestingID = c.Int(nullable: false, identity: true),
                        ProjectID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PerformancetestingID)
                .ForeignKey("dbo.Projects", t => t.ProjectID, cascadeDelete: true)
                .Index(t => t.ProjectID);
            
            CreateTable(
                "dbo.ProductBuilds",
                c => new
                    {
                        ProductBuildID = c.Int(nullable: false, identity: true),
                        ProjectID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ProductBuildID)
                .ForeignKey("dbo.Projects", t => t.ProjectID, cascadeDelete: true)
                .Index(t => t.ProjectID);
            
            CreateTable(
                "dbo.ProjectChangeControls",
                c => new
                    {
                        ProjectChangeControlID = c.Int(nullable: false, identity: true),
                        ProjectID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ProjectChangeControlID)
                .ForeignKey("dbo.Projects", t => t.ProjectID, cascadeDelete: true)
                .Index(t => t.ProjectID);
            
            CreateTable(
                "dbo.ProjectCharters",
                c => new
                    {
                        ProjectCharterID = c.Int(nullable: false, identity: true),
                        ProjectID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ProjectCharterID)
                .ForeignKey("dbo.Projects", t => t.ProjectID, cascadeDelete: true)
                .Index(t => t.ProjectID);
            
            CreateTable(
                "dbo.ProjectKickOffs",
                c => new
                    {
                        ProjectKickOffID = c.Int(nullable: false, identity: true),
                        ProjectID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ProjectKickOffID)
                .ForeignKey("dbo.Projects", t => t.ProjectID, cascadeDelete: true)
                .Index(t => t.ProjectID);
            
            CreateTable(
                "dbo.ProjectSchedules",
                c => new
                    {
                        ProjectScheduleID = c.Int(nullable: false, identity: true),
                        ProjectID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ProjectScheduleID)
                .ForeignKey("dbo.Projects", t => t.ProjectID, cascadeDelete: true)
                .Index(t => t.ProjectID);
            
            CreateTable(
                "dbo.ProjectSharepointSites",
                c => new
                    {
                        ProjectSharepointSiteID = c.Int(nullable: false, identity: true),
                        ProjectID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ProjectSharepointSiteID)
                .ForeignKey("dbo.Projects", t => t.ProjectID, cascadeDelete: true)
                .Index(t => t.ProjectID);
            
            CreateTable(
                "dbo.ProjectSizingWorksheets",
                c => new
                    {
                        ProjectSizingWorksheetID = c.Int(nullable: false, identity: true),
                        ProjectID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ProjectSizingWorksheetID)
                .ForeignKey("dbo.Projects", t => t.ProjectID, cascadeDelete: true)
                .Index(t => t.ProjectID);
            
            CreateTable(
                "dbo.ProjectStatusReports",
                c => new
                    {
                        ProjectStatusReportID = c.Int(nullable: false, identity: true),
                        ProjectID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ProjectStatusReportID)
                .ForeignKey("dbo.Projects", t => t.ProjectID, cascadeDelete: true)
                .Index(t => t.ProjectID);
            
            CreateTable(
                "dbo.QATestPlans",
                c => new
                    {
                        QATestPlanID = c.Int(nullable: false, identity: true),
                        ProjectID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.QATestPlanID)
                .ForeignKey("dbo.Projects", t => t.ProjectID, cascadeDelete: true)
                .Index(t => t.ProjectID);
            
            CreateTable(
                "dbo.QualityPlans",
                c => new
                    {
                        QualityPlanID = c.Int(nullable: false, identity: true),
                        ProjectID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.QualityPlanID)
                .ForeignKey("dbo.Projects", t => t.ProjectID, cascadeDelete: true)
                .Index(t => t.ProjectID);
            
            CreateTable(
                "dbo.RFCs",
                c => new
                    {
                        RFCID = c.Int(nullable: false, identity: true),
                        ProjectID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.RFCID)
                .ForeignKey("dbo.Projects", t => t.ProjectID, cascadeDelete: true)
                .Index(t => t.ProjectID);
            
            CreateTable(
                "dbo.RiskandIssueLogs",
                c => new
                    {
                        RiskandIssueLogID = c.Int(nullable: false, identity: true),
                        ProjectID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.RiskandIssueLogID)
                .ForeignKey("dbo.Projects", t => t.ProjectID, cascadeDelete: true)
                .Index(t => t.ProjectID);
            
            CreateTable(
                "dbo.SecurityRiskAssessments",
                c => new
                    {
                        SecurityRiskAssessmentID = c.Int(nullable: false, identity: true),
                        ProjectID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.SecurityRiskAssessmentID)
                .ForeignKey("dbo.Projects", t => t.ProjectID, cascadeDelete: true)
                .Index(t => t.ProjectID);
            
            CreateTable(
                "dbo.ServiceComminucationPlans",
                c => new
                    {
                        ServiceComminucationPlanID = c.Int(nullable: false, identity: true),
                        ProjectID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ServiceComminucationPlanID)
                .ForeignKey("dbo.Projects", t => t.ProjectID, cascadeDelete: true)
                .Index(t => t.ProjectID);
            
            CreateTable(
                "dbo.ServiceLevelAgreements",
                c => new
                    {
                        ServiceLevelAgreementID = c.Int(nullable: false, identity: true),
                        ProjectID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ServiceLevelAgreementID)
                .ForeignKey("dbo.Projects", t => t.ProjectID, cascadeDelete: true)
                .Index(t => t.ProjectID);
            
            CreateTable(
                "dbo.SmokeTestings",
                c => new
                    {
                        SmokeTestingID = c.Int(nullable: false, identity: true),
                        ProjectID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.SmokeTestingID)
                .ForeignKey("dbo.Projects", t => t.ProjectID, cascadeDelete: true)
                .Index(t => t.ProjectID);
            
            CreateTable(
                "dbo.SupportPlans",
                c => new
                    {
                        SupportPlanID = c.Int(nullable: false, identity: true),
                        ProjectID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.SupportPlanID)
                .ForeignKey("dbo.Projects", t => t.ProjectID, cascadeDelete: true)
                .Index(t => t.ProjectID);
            
            CreateTable(
                "dbo.TechnicalSpecificationDocuments",
                c => new
                    {
                        TechnicalSpecificationDocumentID = c.Int(nullable: false, identity: true),
                        ProjectID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.TechnicalSpecificationDocumentID)
                .ForeignKey("dbo.Projects", t => t.ProjectID, cascadeDelete: true)
                .Index(t => t.ProjectID);
            
            CreateTable(
                "dbo.TestIssueReports",
                c => new
                    {
                        TestIssueReportsID = c.Int(nullable: false, identity: true),
                        ProjectID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.TestIssueReportsID)
                .ForeignKey("dbo.Projects", t => t.ProjectID, cascadeDelete: true)
                .Index(t => t.ProjectID);
            
            CreateTable(
                "dbo.TrainingSchedules",
                c => new
                    {
                        TrainingScheduleID = c.Int(nullable: false, identity: true),
                        ProjectID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.TrainingScheduleID)
                .ForeignKey("dbo.Projects", t => t.ProjectID, cascadeDelete: true)
                .Index(t => t.ProjectID);
            
            CreateTable(
                "dbo.AspNetRoles",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true, name: "RoleNameIndex");
            
            CreateTable(
                "dbo.AspNetUserRoles",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        RoleId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.UserId, t.RoleId })
                .ForeignKey("dbo.AspNetRoles", t => t.RoleId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.AspNetUsers",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Email = c.String(maxLength: 256),
                        EmailConfirmed = c.Boolean(nullable: false),
                        PasswordHash = c.String(),
                        SecurityStamp = c.String(),
                        PhoneNumber = c.String(),
                        PhoneNumberConfirmed = c.Boolean(nullable: false),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        LockoutEndDateUtc = c.DateTime(),
                        LockoutEnabled = c.Boolean(nullable: false),
                        AccessFailedCount = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.UserName, unique: true, name: "UserNameIndex");
            
            CreateTable(
                "dbo.AspNetUserClaims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(nullable: false, maxLength: 128),
                        ClaimType = c.String(),
                        ClaimValue = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.AspNetUserLogins",
                c => new
                    {
                        LoginProvider = c.String(nullable: false, maxLength: 128),
                        ProviderKey = c.String(nullable: false, maxLength: 128),
                        UserId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.LoginProvider, t.ProviderKey, t.UserId })
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserClaims", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles");
            DropForeignKey("dbo.TrainingSchedules", "ProjectID", "dbo.Projects");
            DropForeignKey("dbo.TestIssueReports", "ProjectID", "dbo.Projects");
            DropForeignKey("dbo.TechnicalSpecificationDocuments", "ProjectID", "dbo.Projects");
            DropForeignKey("dbo.SupportPlans", "ProjectID", "dbo.Projects");
            DropForeignKey("dbo.SmokeTestings", "ProjectID", "dbo.Projects");
            DropForeignKey("dbo.ServiceLevelAgreements", "ProjectID", "dbo.Projects");
            DropForeignKey("dbo.ServiceComminucationPlans", "ProjectID", "dbo.Projects");
            DropForeignKey("dbo.SecurityRiskAssessments", "ProjectID", "dbo.Projects");
            DropForeignKey("dbo.RiskandIssueLogs", "ProjectID", "dbo.Projects");
            DropForeignKey("dbo.RFCs", "ProjectID", "dbo.Projects");
            DropForeignKey("dbo.QualityPlans", "ProjectID", "dbo.Projects");
            DropForeignKey("dbo.QATestPlans", "ProjectID", "dbo.Projects");
            DropForeignKey("dbo.ProjectStatusReports", "ProjectID", "dbo.Projects");
            DropForeignKey("dbo.ProjectSizingWorksheets", "ProjectID", "dbo.Projects");
            DropForeignKey("dbo.ProjectSharepointSites", "ProjectID", "dbo.Projects");
            DropForeignKey("dbo.ProjectSchedules", "ProjectID", "dbo.Projects");
            DropForeignKey("dbo.ProjectKickOffs", "ProjectID", "dbo.Projects");
            DropForeignKey("dbo.ProjectCharters", "ProjectID", "dbo.Projects");
            DropForeignKey("dbo.ProjectChangeControls", "ProjectID", "dbo.Projects");
            DropForeignKey("dbo.ProductBuilds", "ProjectID", "dbo.Projects");
            DropForeignKey("dbo.Performancetestings", "ProjectID", "dbo.Projects");
            DropForeignKey("dbo.PartBs", "ProjectID", "dbo.Projects");
            DropForeignKey("dbo.PartAs", "ProjectID", "dbo.Projects");
            DropForeignKey("dbo.LessonsLearneds", "ProjectID", "dbo.Projects");
            DropForeignKey("dbo.InitialTrainingPlans", "ProjectID", "dbo.Projects");
            DropForeignKey("dbo.InitialSupportPlans", "ProjectID", "dbo.Projects");
            DropForeignKey("dbo.InitialProjectPlans", "ProjectID", "dbo.Projects");
            DropForeignKey("dbo.InitialCommunivcationsPlans", "ProjectID", "dbo.Projects");
            DropForeignKey("dbo.ImplemenationPlans", "ProjectID", "dbo.Projects");
            DropForeignKey("dbo.ExecuteUATtestPlanandUseCases", "ProjectID", "dbo.Projects");
            DropForeignKey("dbo.DevelopUATTestPlanandUseCases", "ProjectID", "dbo.Projects");
            DropForeignKey("dbo.DecisionLogs", "ProjectID", "dbo.Projects");
            DropForeignKey("dbo.CustomerAcceptances", "ProjectID", "dbo.Projects");
            DropForeignKey("dbo.CloseOutChecklists", "ProjectID", "dbo.Projects");
            DropForeignKey("dbo.BusinessRequirements", "ProjectID", "dbo.Projects");
            DropForeignKey("dbo.BudgetPlans", "ProjectID", "dbo.Projects");
            DropForeignKey("dbo.PartAResources", "PartAID", "dbo.PartAs");
            DropForeignKey("dbo.PartAPopulationAffecteds", "PartAID", "dbo.PartAs");
            DropForeignKey("dbo.PartAApplicationAffecteds", "PartAID", "dbo.PartAs");
            DropIndex("dbo.AspNetUserLogins", new[] { "UserId" });
            DropIndex("dbo.AspNetUserClaims", new[] { "UserId" });
            DropIndex("dbo.AspNetUsers", "UserNameIndex");
            DropIndex("dbo.AspNetUserRoles", new[] { "RoleId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "UserId" });
            DropIndex("dbo.AspNetRoles", "RoleNameIndex");
            DropIndex("dbo.TrainingSchedules", new[] { "ProjectID" });
            DropIndex("dbo.TestIssueReports", new[] { "ProjectID" });
            DropIndex("dbo.TechnicalSpecificationDocuments", new[] { "ProjectID" });
            DropIndex("dbo.SupportPlans", new[] { "ProjectID" });
            DropIndex("dbo.SmokeTestings", new[] { "ProjectID" });
            DropIndex("dbo.ServiceLevelAgreements", new[] { "ProjectID" });
            DropIndex("dbo.ServiceComminucationPlans", new[] { "ProjectID" });
            DropIndex("dbo.SecurityRiskAssessments", new[] { "ProjectID" });
            DropIndex("dbo.RiskandIssueLogs", new[] { "ProjectID" });
            DropIndex("dbo.RFCs", new[] { "ProjectID" });
            DropIndex("dbo.QualityPlans", new[] { "ProjectID" });
            DropIndex("dbo.QATestPlans", new[] { "ProjectID" });
            DropIndex("dbo.ProjectStatusReports", new[] { "ProjectID" });
            DropIndex("dbo.ProjectSizingWorksheets", new[] { "ProjectID" });
            DropIndex("dbo.ProjectSharepointSites", new[] { "ProjectID" });
            DropIndex("dbo.ProjectSchedules", new[] { "ProjectID" });
            DropIndex("dbo.ProjectKickOffs", new[] { "ProjectID" });
            DropIndex("dbo.ProjectCharters", new[] { "ProjectID" });
            DropIndex("dbo.ProjectChangeControls", new[] { "ProjectID" });
            DropIndex("dbo.ProductBuilds", new[] { "ProjectID" });
            DropIndex("dbo.Performancetestings", new[] { "ProjectID" });
            DropIndex("dbo.PartBs", new[] { "ProjectID" });
            DropIndex("dbo.LessonsLearneds", new[] { "ProjectID" });
            DropIndex("dbo.InitialTrainingPlans", new[] { "ProjectID" });
            DropIndex("dbo.InitialSupportPlans", new[] { "ProjectID" });
            DropIndex("dbo.InitialProjectPlans", new[] { "ProjectID" });
            DropIndex("dbo.InitialCommunivcationsPlans", new[] { "ProjectID" });
            DropIndex("dbo.ImplemenationPlans", new[] { "ProjectID" });
            DropIndex("dbo.ExecuteUATtestPlanandUseCases", new[] { "ProjectID" });
            DropIndex("dbo.DevelopUATTestPlanandUseCases", new[] { "ProjectID" });
            DropIndex("dbo.DecisionLogs", new[] { "ProjectID" });
            DropIndex("dbo.CustomerAcceptances", new[] { "ProjectID" });
            DropIndex("dbo.CloseOutChecklists", new[] { "ProjectID" });
            DropIndex("dbo.BusinessRequirements", new[] { "ProjectID" });
            DropIndex("dbo.BudgetPlans", new[] { "ProjectID" });
            DropIndex("dbo.PartAs", new[] { "ProjectID" });
            DropIndex("dbo.PartAResources", new[] { "PartAID" });
            DropIndex("dbo.PartAPopulationAffecteds", new[] { "PartAID" });
            DropIndex("dbo.PartAApplicationAffecteds", new[] { "PartAID" });
            DropTable("dbo.AspNetUserLogins");
            DropTable("dbo.AspNetUserClaims");
            DropTable("dbo.AspNetUsers");
            DropTable("dbo.AspNetUserRoles");
            DropTable("dbo.AspNetRoles");
            DropTable("dbo.TrainingSchedules");
            DropTable("dbo.TestIssueReports");
            DropTable("dbo.TechnicalSpecificationDocuments");
            DropTable("dbo.SupportPlans");
            DropTable("dbo.SmokeTestings");
            DropTable("dbo.ServiceLevelAgreements");
            DropTable("dbo.ServiceComminucationPlans");
            DropTable("dbo.SecurityRiskAssessments");
            DropTable("dbo.RiskandIssueLogs");
            DropTable("dbo.RFCs");
            DropTable("dbo.QualityPlans");
            DropTable("dbo.QATestPlans");
            DropTable("dbo.ProjectStatusReports");
            DropTable("dbo.ProjectSizingWorksheets");
            DropTable("dbo.ProjectSharepointSites");
            DropTable("dbo.ProjectSchedules");
            DropTable("dbo.ProjectKickOffs");
            DropTable("dbo.ProjectCharters");
            DropTable("dbo.ProjectChangeControls");
            DropTable("dbo.ProductBuilds");
            DropTable("dbo.Performancetestings");
            DropTable("dbo.PartBs");
            DropTable("dbo.LessonsLearneds");
            DropTable("dbo.InitialTrainingPlans");
            DropTable("dbo.InitialSupportPlans");
            DropTable("dbo.InitialProjectPlans");
            DropTable("dbo.InitialCommunivcationsPlans");
            DropTable("dbo.ImplemenationPlans");
            DropTable("dbo.ExecuteUATtestPlanandUseCases");
            DropTable("dbo.DevelopUATTestPlanandUseCases");
            DropTable("dbo.DecisionLogs");
            DropTable("dbo.CustomerAcceptances");
            DropTable("dbo.CloseOutChecklists");
            DropTable("dbo.BusinessRequirements");
            DropTable("dbo.BudgetPlans");
            DropTable("dbo.Projects");
            DropTable("dbo.PartAs");
            DropTable("dbo.PartAResources");
            DropTable("dbo.PartAPopulationAffecteds");
            DropTable("dbo.PartAApplicationAffecteds");
        }
    }
}
