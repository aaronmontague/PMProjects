using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PMProjects.Models
{
    public class Project
    {
        [DisplayName("Project ID")]
        public int ProjectID { get; set; }

        [Required]
        [DisplayName("Project Name")]
        public string ProjectName { get; set; }

        [DisplayName("Project Sizing Score")]
        public int? ProjectSizingScore { get; set; }

        [DataType(DataType.Date)]
        //getting date to display correctly: http://goo.gl/KPzg6a
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        [Column(TypeName = "Date")]
        [DisplayName("Start Date")]
        public DateTime StartDate { get; set; }

        [DataType(DataType.Date)]
        //getting date to display correctly: http://goo.gl/KPzg6a
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        [Column(TypeName = "Date")]
        [DisplayName("Desired End Date")]
        public DateTime? EndDate { get; set; }

        [DataType(DataType.Date)]
        //getting date to display correctly: http://goo.gl/KPzg6a
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        [Column(TypeName = "Date")]
        [DisplayName("Actual End Date")]
        public DateTime? AcutalEndDate { get; set; }

        [DisplayName("CHG Number")]
        public int? CHGnumber { get; set; }

        [Required]
        [DisplayName("Project Description")]
        public string ProjectDescription { get; set; }

        //need status options
        [DisplayName("Project Status")]
        public string ProjectStatus { get; set; }

        //need phase options
        [DisplayName("Current Phase")]
        public string ProjectCurrentPhase { get; set; }

        //pictures
        //each is an individual status
        //any slip to a lower status in Schedule, Scope or Budget drive overall to that lower status
        public string RYGStatus { get; set; }
        public string RYGSchedule { get; set; }
        public string RYGScope { get; set; }
        public string RYGBudget { get; set; }

        //get from Part A?
        [DisplayName("Project Risk")]
        public int? ProjectLevelOfRisk { get; set; }

        //may not need at all
        [DisplayName("Project Milestones")]
        public string UpComingMilestones { get; set; }

        //going to need good layout
        [DisplayName("Key Risk Issues")]
        public string KeyIssuesRisks { get; set; }

        [DisplayName("Initial Budget")]
        public double? ProjectInitialBudget { get; set; }

        [DisplayName("ITS Lead")]
        public string ITSLead { get; set; }

        [DisplayName("ITS Project Manager")]
        public string ITSProjectManageer { get; set; }

        [DisplayName("SVP Sponsor")]
        public string SVPSponsor { get; set; }

        //components
        public List<PartA> PartAs { get; set; }
        public List<PartB> PartBs { get; set; }
        public List<ProjectSizingWorksheet> ProjectSizingWorksheets { get; set; }
        public List<InitialProjectPlan> InitialProjectPlans { get; set; }
        public List<RFC> RFCs { get; set; }
        public List<ProjectSharepointSite> ProjectSharepointSites { get; set; }
        public List<SecurityRiskAssessment> SecurityRiskAssessments { get; set; }
        public List<ProjectCharter> ProjectCharters { get; set; }
        public List<QualityPlan> QualityPlans { get; set; }
        public List<ProjectKickOff> ProjectKickOffs { get; set; }
        public List<ProjectSchedule> ProjectSchedules { get; set; }
        public List<BudgetPlan> BudgetPlans { get; set; }
        public List<InitialTrainingPlan> InitialTrainingPlans { get; set; }
        public List<InitialCommunivcationsPlan> InitialCommunivcationsPlans { get; set; }
        public List<InitialSupportPlan> InitialSupportPlans { get; set; }
        public List<BusinessRequirement> BusinessRequirements { get; set; }
        public List<TechnicalSpecificationDocument> TechnicalSpecificationDocuments { get; set; }
        public List<DevelopUATTestPlanandUseCases> DevelopUATTestPlanandUseCasess { get; set; }
        public List<SmokeTesting> SmokeTestings { get; set; }
        public List<Performancetesting> Performancetestings { get; set; }
        public List<QATestPlan> QATestPlans { get; set; }
        public List<ProductBuild> ProductBuilds { get; set; }
        public List<TestIssueReports> TestIssueReportss { get; set; }
        public List<ExecuteUATtestPlanandUseCases> ExecuteUATtestPlanandUseCasess { get; set; }
        public List<CustomerAcceptance> CustomerAcceptances { get; set; }
        public List<ImplemenationPlan> ImplemenationPlans { get; set; }
        public List<TrainingSchedule> TrainingSchedules { get; set; }
        public List<ServiceComminucationPlan> ServiceComminucationPlans { get; set; }
        public List<ServiceLevelAgreement> ServiceLevelAgreements { get; set; }
        public List<SupportPlan> SupportPlans { get; set; }
        public List<CloseOutChecklist> CloseOutChecklists { get; set; }
        public List<LessonsLearned> LessonsLearneds { get; set; }
        public List<ProjectStatusReport> ProjectStatusReports { get; set; }
        public List<RiskandIssueLog> RiskandIssueLogs { get; set; }
        public List<DecisionLog> DecisionLogs { get; set; }
        public List<ProjectChangeControl> ProjectChangeControls { get; set; }

    }
}