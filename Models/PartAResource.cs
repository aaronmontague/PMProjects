using System.ComponentModel;

namespace PMProjects.Models
{
    public class PartAResource
    {
        public int PartAResourceID { get; set; }
        public int PartAID { get; set; }
        //following should give me a drop down of Part A's
        public virtual PartA PartA { get; set; }

        [DisplayName("Resource Name")]
        public string ResourceName { get; set; }

        [DisplayName("Initial Cost")]
        public decimal InitialCost { get; set; }

        [DisplayName("Recurring Cost(s)")]
        public decimal RecurringCost { get; set; }

        [DisplayName("Funding Source")]
        public string FundingSource { get; set; }
    }
}