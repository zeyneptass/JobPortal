using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class User: IEntitiy
    {
        public int UserId { get; set; }
        public int RoleId { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        //public string Role { get; set; } // Employer veya JobSeeker
        public DateTime CreatedAt { get; set; }
    }

}
