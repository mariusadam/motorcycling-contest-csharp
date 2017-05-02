using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Networking.ObjectProtocol.Request
{
	[Serializable()]
    public class AddTeamRequest : Request
    {
		public string TeamName { get; set; }
    }
}
