﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class JobType : IEntitiy
    {
        public int JobTypeId { get; set; }
        public string JobStyle { get; set; }
    }
}
