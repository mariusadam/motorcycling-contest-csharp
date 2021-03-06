﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotorcyclingContestApp.Domain
{
    public class Contestant
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public EngineCapacity EngineCapacity { get; set; }

        public Team Team { get; set; }

        public override string ToString()
        {
            return Name ?? "Null team";
        }
    }
}
