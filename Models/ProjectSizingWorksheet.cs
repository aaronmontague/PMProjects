using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PMProjects.Models
{
    public class ProjectSizingWorksheet
    {
        [Required]
        [DisplayName("Project ID")]
        public int ProjectID { get; set; }
        //following gives a drop down of available projects
        public virtual Project Project { get; set; }

        public int ProjectSizingWorksheetID { get; set; }

        [DisplayName("# Team Members")]
        public int? Question1Value { get; set; }

        [DisplayName("Project Duration/Schedule")]
        public int? Question2Value { get; set; }

        [DisplayName("Project Complexity")]
        public int? Question3Value { get; set; }

        [DisplayName("Technical Complexity")]
        public int? Question4Value { get; set; }

        [DisplayName("Strategic Importance")]
        public int? Question5Value { get; set; }

        [DisplayName("Regulatory Characteristics")]
        public int? Question6Value { get; set; }

        [DisplayName("Requirement Stability ")]
        public int? Question7Value { get; set; }

        [DisplayName("Level of Change")]
        public int? Question8Value { get; set; }

        [DisplayName("External Dependencies and Inter-related Projects")]
        public int? Question9Value { get; set; }

        [DisplayName("Project Cost")]
        public int? Question10Value { get; set; }

        [DisplayName("Project Sizing Score")]
        public int? ProjectSizingScore { get; set; }
    }
}