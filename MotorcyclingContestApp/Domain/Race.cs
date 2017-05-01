using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotorcyclingContestApp.Domain
{
    public class Race
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public DateTime StarTime { get; set; }

        public override string ToString()
        {
            return Name ?? "Null race";
        }
    }
}