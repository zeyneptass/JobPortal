using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class JobSeeker: IEntitiy
    {
        public int JobSeekerId { get; set; }
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Resume { get; set; } // Özgeçmiş dosyasının yolu
        //public User User { get; set; }
    }

}
