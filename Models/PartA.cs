using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PMProjects.Models
{
    public class PartA
    {
        [Required]
        [DisplayName("Project ID")]
        public int ProjectID { get; set; }
        //following should give me a drop down when creating Part A's 
        public virtual Project Project { get; set; }

        [DisplayName("Part A ID")]
        public int PartAID { get; set; }
        [DisplayName("Proposal Title")]
        public string ProposalTitle { get; set; }
        [DisplayName("Proposal Number")]
        public int ProposalNumber { get; set; } //should equal project number I think

        [Required]
        public int SponsorID { get; set; }
        //following should give me a drop down for Sponsors
        public virtual Sponsor Sponsor { get; set; }

        [DisplayName("Primary Contact")]
        public string PrimaryContact { get; set; }

        [DataType(DataType.Date)]
        //getting date to display correctly: http://goo.gl/KPzg6a
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        [Column(TypeName = "Date")]
        [DisplayName("Desired Completion Date")]
        public DateTime DesiredDateComplete { get; set; }

        [DisplayName("SVP Approved?")]
        public bool SVPApproved { get; set; }

        [DisplayName("Will this take longer than 2 weeks?")]
        public bool LongerThanTwoWeeks { get; set; }

        [DisplayName("Project Overview")]
        public string ProjectOverview { get; set; }

        [DisplayName("Business Case")]
        public string BusinessCase { get; set; }

        [DisplayName("Core Software Interfaces")]
        public string CoreInterfaces { get; set; }

        [DisplayName("Business Risks")]
        public string BusinessRisks { get; set; }
        
        public List<PartAApplicationAffected> PartAApplicationAffecteds { get; set; }
        public List<PartAPopulationAffected> PartAPopulationAffecteds { get; set; }
        public List<PartAResource> PartAResource { get; set; }
    }
}