using Core;
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Role : IEntitiy
    {
        public int RoleId { get; set; }
        public string UserRole { get; set; }
    }
}
