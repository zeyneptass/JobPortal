using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.Concrete
{
    public class OperationClaim :IEntitiy
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
