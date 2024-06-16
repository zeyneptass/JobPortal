using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Application : IEntitiy
    {
        public int ApplicationId { get; set; }
        public int JobListingId { get; set; }
        public int JobSeekerId { get; set; }
        public DateTime AppliedDate { get; set; }
        public string Status { get; set; } // Pending, Accepted, Rejected, vb.
        //public JobListing JobListing { get; set; }
        //public JobSeeker JobSeeker { get; set; }
    }

}
