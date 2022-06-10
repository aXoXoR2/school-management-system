﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystem.Domain.Entities
{
    public class AditionalService : Entity
    {
        public Worker Worker { get; set; }
        public Resource Resource { get; set; }
        public int WorkerPorcentageProfits { get; set; }

    }
}
