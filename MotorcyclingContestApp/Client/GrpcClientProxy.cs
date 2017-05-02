using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Generated;
using Grpc.Core;
using Microsoft.Practices.Unity;
using MotorcyclingContestApp.Domain;
using Status = Generated.Status;

namespace MotorcyclingContestApp.Client
{
    public class ClientProxy
    {
        private readonly MotoContest.MotoContestClient _client;
        public Channel Channel { get; }
        private Converter _converter;

        public ClientProxy([Dependency()] Channel channel, [Dependency()] Converter converter)
        {
            _converter = converter;
            Channel = channel;
            this._client = new MotoContest.MotoContestClient(Channel);
        }

        public async void Subscribe(List<Event.Types.Name> eventsNames, Action<Event> eventsHandler)
        {
            var request = new SubscribeRequest
            {
                EventName = {eventsNames}
            };

            try
            {
                using (var call = _client.Subscribe(request))
                {
                    var responseStream = call.ResponseStream;
                    while (await responseStream.MoveNext())
                    {
                        var e = responseStream.Current;
                        eventsHandler(e);
                    }
                }
            }
            catch (RpcException e)
            {
                Console.WriteLine("Rpc failed " + e.Message);
                //throw;
            }
        }

        public HelloReply SayHello(string user)
        {
            return _client.SayHello(new HelloRequest
                {
                    Name = user
                }
            );
        }

        public HelloReply SayHelloAgain(string user)
        {
            return _client.SayHelloAgain(new HelloRequest
                {
                    Name = user
                }
            );
        }

        public LoginReply Login(string email, string password)
        {
            return _client.Login(
                new LoginRequest
                {
                    Email = email,
                    Password = password
                }
            );
        }

        public GetContestantsReply GetContestants()
        {
            return _client.GetContestants(new GetContestantsRequest());
        }

        public SearchContestantsReply SearchContestatns(string teamName)
        {
            return _client.Search(
                new SearchContestantsRequest
                {
                    TeamName = teamName
                }
            );
        }

        public List<Race> GetRaces()
        {
            var reply = _client.GetRaces(
                new Empty()
            );

            var result = new List<Race>();
            if (reply.Status != Generated.Status.Ok)
            {
                return result;
            }

            foreach (var r in reply.Race)
            {
                result.Add(_converter.ToPoco(r));
            }
            return result;
        }

        public SimpleReply RegisterContestant(string contestantName, Team team, EngineCapacity ec,
            IEnumerable<Race> races)
        {
            var request = new RegisterContestantRequest();
            request.ContestantName = contestantName;
            request.Team = _converter.ToDto(team);
            request.EngineCapacity = _converter.ToDto(ec);
            foreach (var race in races)
            {
                request.Race.Add(_converter.ToDto(race));
            }

            return _client.RegisterContestant(request);
        }

        public IEnumerable<Team> GetTeams()
        {
            var reply = _client.GetTeams(new Empty());
            var result = new List<Team>();
            if (reply.Status != Status.Ok)
            {
                return result;
            }

            foreach (var teamDto in reply.Team)
            {
                result.Add(_converter.ToPoco(teamDto));
            }

            return result;
        }

        public IEnumerable<EngineCapacity> GetEngineCapacities()
        {
            var reply = _client.GetEngineCapacities(new Empty());
            var result = new List<EngineCapacity>();
            if (reply.Status != Status.Ok)
            {
                return result;
            }

            foreach (var ecDto in reply.EngineCapacity)
            {
                result.Add(_converter.ToPoco(ecDto));
            }

            return result;
        }

        public SimpleReply AddTeam(string teamName)
        {
            return _client.AddTeam(
                new AddTeamRequest
                {
                    TeamName = teamName
                }
            );
        }

        public async void GetRacesParticipants(Action<Race, int> addRaceDelegate)
        {
            var request = new Empty();
            var result = new List<Race>();
            try
            {
                using (var call = _client.GetRacesParticipants(request))
                {
                    var responseStream = call.ResponseStream;
                    while (await responseStream.MoveNext())
                    {
                        var raceDto = responseStream.Current;
                        addRaceDelegate(
                            _converter.ToPoco(raceDto.Race),
                            raceDto.NumberOfParticipants
                        );
                    }
                }
            }
            catch (RpcException e)
            {
                Console.WriteLine("Rpc failed " + e.Message);
                //throw;
            }
        }

        private ClientException WrapException(Exception e)
        {
            return new ClientException(e.Message, e);
        }
    }
}