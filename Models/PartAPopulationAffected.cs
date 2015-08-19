using System.ComponentModel;

namespace PMProjects.Models
{
    public class PartAPopulationAffected
    {
        public int PartAID { get; set; }
        //following should give me a drop down of Part A's
        public virtual PartA PartA { get; set; }

        public int PartAPopulationAffectedID { get; set; }

        [DisplayName("Who is affected?")]
        public string PopulationName { get; set; }

        [DisplayName("What is the impact?")]
        public string SpecificImpact { get; set; }

        [DisplayName("Severity of impact")]
        public string ImpactLevel { get; set; } //high,med,low,none
    }
}