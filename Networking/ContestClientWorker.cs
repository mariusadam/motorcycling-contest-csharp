using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MotorcyclingContestApp.Domain;
using Networking.ObjectProtocol.Request;
using Networking.ObjectProtocol.Response;
using Services;

namespace Networking
{
    public class ContestClientWorker : IContestObserver
    {
        private IContestServer _server;
        private TcpClient _connection;
        private NetworkStream _stream;
        private IFormatter _formatter;
        private volatile bool _connected;

        public ContestClientWorker(IContestServer server, TcpClient connection)
        {
            _server = server;
            _connection = connection;
            try
            {
                _stream = connection.GetStream();
                _formatter = new BinaryFormatter();
                _connected = true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
        }

        public virtual void run()
        {
            while (_connected)
            {
                try
                {
                    object request = _formatter.Deserialize(_stream);
                    object response = HandleRequest((Request) request);
                    if (response != null)
                    {
                        SendResponse((Response) response);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.StackTrace);
                }

                try
                {
                    Thread.Sleep(1000);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.StackTrace);
                }
            }
            try
            {
                _stream.Close();
                _connection.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error " + e);
            }
        }

        private void SendResponse(Response response)
        {
            Console.WriteLine("sending response " + response);
            _formatter.Serialize(_stream, response);
            _stream.Flush();
        }

        private object HandleRequest(Request request)
        {
            Response response = null;
            if (request is LoginRequest)
            {
                Console.WriteLine("Login Request....");
                var r = (LoginRequest)request;
                try
                {
                    lock (_server)
                    {
                        _server.Login(r.Email, r.Password);
                    }
                    return new OkResponse();
                }
                catch (Exception ex)
                {
                    _connected = false;
                    return new ErrorReponse
                    {
                        Message = ex.Message
                    };
                }
            }
            if (request is GetItemsRequest<Contestant>)
            {
                Console.WriteLine("Get items....");
                try
                {
                    IList<Contestant> items;
                    lock (_server)
                    {
                        items = _server.GetContestants();
                    }
                    return new GetItemsResponse<Contestant>
                    {
                        Items = items
                    };
                }
                catch (Exception ex)
                {
                    return new ErrorReponse
                    {
                        Message = ex.Message
                    };
                }
            }

            return response;
        }

        public void HandleEvent(Event e)
        {
            throw new NotImplementedException();
        }
    }
}