using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Networking.ObjectProtocol.Response
{
    [Serializable()]
    public class ErrorReponse : Response
    {
        public string Message { get; set; }
    }
}
