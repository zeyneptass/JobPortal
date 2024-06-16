using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class JobListing: IEntitiy
    {
        public int JobListingId { get; set; }
        public int EmployerId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public int JobTypeId { get; set; } // Full-Time, Part-Time, vb.
        public DateTime PostedDate { get; set; }
        //public Employer Employer { get; set; }
    }

}
