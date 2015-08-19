using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace PMProjects.Models
{
    public class Sponsor
    {
        [DisplayName("Sponsor")]
        public int SponsorID { get; set; }

        [DisplayName("Sponsor")]
        public string SponsorName { get; set; }
    }
}