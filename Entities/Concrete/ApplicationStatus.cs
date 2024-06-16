using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class ApplicationStatus :IEntitiy
    {
        public int StatusId { get; set; }
        public string StatusName { get; set; }
    }
}
