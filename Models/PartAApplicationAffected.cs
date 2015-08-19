using System.ComponentModel;

namespace PMProjects.Models
{
    public class PartAApplicationAffected
    {
        public int PartAApplicationAffectedID { get; set; }
        public int PartAID { get; set; }
        //following should give me a drop down of Part A's
        public virtual PartA PartA { get; set; }

        [DisplayName("Affected Application")]
        public string ApplicationName { get; set; }

        [DisplayName("Certainty of Effect")]
        public string CertaintyOfAffect { get; set; }//high,med,low

        [DisplayName("Level of Impact")]
        public string ImpactOfAffect { get; set; }//high,med,low
    }
}