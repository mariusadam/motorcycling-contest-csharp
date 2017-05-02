using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Networking.ObjectProtocol.Response
{
    [Serializable()]
    public class GetItemsResponse<T> : Response
    {
        public IList<T> Items { get; set; }

        public GetItemsResponse()
        {
            Items = new List<T>();
        }
    }
}
