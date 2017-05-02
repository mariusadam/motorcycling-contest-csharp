using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MotorcyclingContestApp.Domain;
using Networking.ObjectProtocol.Response;
using Services;

namespace Networking
{
    public class ContestServerObjProxy : IContestServer
    {
        private string _host;
        private int _port;
        private IContestObserver _client;
        private NetworkStream _stream;
        private IFormatter _formatter;
        private TcpClient _connection;
        private Queue<Response> _responses;
        private volatile bool _finished;
        private EventWaitHandle _waitHandle;

        public ContestServerObjProxy(string host, int port)
        {
            _host = host;
            _port = port;
            _responses = new Queue<Response>();
        }

        public void Login(string email, string password)
        {
            throw new NotImplementedException();
        }

        public void Subscribe(IEnumerable<EventName> eventNames)
        {
            throw new NotImplementedException();
        }

        public IList<Contestant> GetContestants()
        {
            throw new NotImplementedException();
        }

        public IList<Contestant> SearchContestants(string teamName)
        {
            throw new NotImplementedException();
        }

        public IList<Race> GetRaces()
        {
            throw new NotImplementedException();
        }

        public void RegisterContestant(string cname, Team team, EngineCapacity ec, IEnumerable<Race> races)
        {
            throw new NotImplementedException();
        }

        public IList<Team> GetTeams()
        {
            throw new NotImplementedException();
        }

        public IList<EngineCapacity> GetEngineCapacities()
        {
            throw new NotImplementedException();
        }

        public void AddTeam(string teamName)
        {
            throw new NotImplementedException();
        }

        public IList<Race> GetRacesParticipants()
        {
            throw new NotImplementedException();
        }

        private void InitializeConnection()
        {
            try
            {
                _connection = new TcpClient(_host, _port);
                _stream = _connection.GetStream();
                _formatter = new BinaryFormatter();
                _finished = false;
                _waitHandle = new AutoResetEvent(false);
                StartReader();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
        }

        private void StartReader()
        {
            Thread tw = new Thread(Run);
            tw.Start();
        }

        public virtual void Run()
        {
            while (!_finished)
            {
                try
                {
                    object response = _formatter.Deserialize(_stream);
                    Console.WriteLine("response received " + response);
                    if (response is OkResponse)
                    {
                        _client.HandleEvent((response as OkResponse).RelatedEvent);
                    }
                    else
                    {
                        lock (_responses)
                        {
                            _responses.Enqueue((Response)response);
                        }
                        _waitHandle.Set();
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Reading error " + e);
                }
            }
        }

        private void CloseConnection()
        {
            _finished = true;
            try
            {
                _stream.Close();
                //output.close();
                _connection.Close();
                _waitHandle.Close();
                _client = null;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}