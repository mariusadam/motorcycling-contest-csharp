using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MotorcyclingContestApp.Domain;

namespace Networking.ObjectProtocol.Response
{
    [Serializable()]
    public class OkResponse : Response
    {
        public Event RelatedEvent { get; set; }
    }
}