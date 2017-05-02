using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MotorcyclingContestApp.Domain;

namespace Networking.ObjectProtocol.Request
{
    [Serializable()]
    public class RegisterContestantRequest : Request
    {
        public string ContestantName { get; set; }
        public Team Team { get; set; }
        public IList<Race> Races { get; }
        public EngineCapacity EngineCapacity { get; set; }

        public RegisterContestantRequest()
        {
            Races = new List<Race>();
        }
    }
}