using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Networking
{
    public abstract class AbstractServer
    {
        private TcpListener _listener;
        private string _host;
        private int _port;

        public AbstractServer(string host, int port)
        {
            _host = host;
            _port = port;
        }

        public void Start()
        {
            var ipAddr = IPAddress.Parse(_host);
            var endpoint = new IPEndPoint(ipAddr, _port);
            _listener = new TcpListener(endpoint);
            _listener.Start();
            while (true)
            {
                Console.WriteLine("Waiting for clients ...");
                var client = _listener.AcceptTcpClient();
                Console.WriteLine("Client connected ...");
                ProcessRequest(client);
            }
        }

        protected abstract void ProcessRequest(TcpClient client);
    }

    public abstract class ConcurrentServer : AbstractServer
    {
        public ConcurrentServer(string host, int port) : base(host, port)
        {
        }

        protected override void ProcessRequest(TcpClient client)
        {
            var t = createWorker(client);
            t.Start();
        }

        protected abstract Thread createWorker(TcpClient client);
    }
}