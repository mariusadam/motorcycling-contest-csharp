using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using Generated;
using Grpc.Core;
using Microsoft.Practices.Unity;
using MotorcyclingContestApp.Domain;
using Status = Generated.Status;

namespace MotorcyclingContestApp.Client
{
    public class GrpcClientProxy : IClientProxy
    {
        private readonly MotoContest.MotoContestClient _client;
        public Channel Channel { get; }
        private readonly Converter _converter;

        public GrpcClientProxy([Dependency()] Channel channel, [Dependency()] Converter converter)
        {
            _converter = converter;
            Channel = channel;
            this._client = new MotoContest.MotoContestClient(Channel);
        }

        public async void Subscribe(IEnumerable<EventName> eventsNames, Action<Domain.Event> eventsHandler)
        {
            var evNamesDto = eventsNames.Select(evn => _converter.ToDto(evn)).ToList();
            var request = new SubscribeRequest
            {
                EventName = {evNamesDto}
            };

            try
            {
                using (var call = _client.Subscribe(request))
                {
                    var responseStream = call.ResponseStream;
                    while (await responseStream.MoveNext())
                    {
                        var e = responseStream.Current;
                        eventsHandler(_converter.ToPoco(e));
                    }
                }
            }
            catch (RpcException e)
            {
                Console.WriteLine("Rpc failed " + e.Message);
                //throw;
            }
        }

        public void Login(string email, string password)
        {
            var reply = _client.Login(
                new LoginRequest
                {
                    Email = email,
                    Password = password
                }
            );
            CheckStatus(reply.Status, reply.Message);
        }

        public IEnumerable<Contestant> GetContestants()
        {
            var reply = _client.GetContestants(new GetContestantsRequest());
            CheckStatus(reply.Status, reply.Message);

            return reply.Contestant.Select(
                contestantDto => _converter.ToPoco(contestantDto)
            ).ToList();
        }

        public IEnumerable<Contestant> SearchContestatns(string teamName)
        {
            var reply = _client.Search(
                new SearchContestantsRequest
                {
                    TeamName = teamName
                }
            );
            CheckStatus(reply.Status, reply.Message);

            return reply.Contestant.Select(
                contestantDto => _converter.ToPoco(contestantDto)
            ).ToList();
        }

        public IEnumerable<Race> GetRaces()
        {
            var reply = _client.GetRaces(
                new Empty()
            );
            CheckStatus(reply.Status, reply.Message);

            return reply.Race.Select(r => _converter.ToPoco(r)).ToList();
        }

        public void RegisterContestant(string contestantName, Team team, EngineCapacity ec,
            IEnumerable<Race> races)
        {
            var request = new RegisterContestantRequest
            {
                ContestantName = contestantName,
                Team = _converter.ToDto(team),
                EngineCapacity = _converter.ToDto(ec)
            };
            foreach (var race in races)
            {
                request.Race.Add(_converter.ToDto(race));
            }

            var reply = _client.RegisterContestant(request);
            CheckStatus(reply.Status, reply.Message);
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

        public void AddTeam(string teamName)
        {
            var reply = _client.AddTeam(
                new AddTeamRequest
                {
                    TeamName = teamName
                }
            );

            CheckStatus(reply.Status, reply.Message);
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

        private void CheckStatus(Status status, string message)
        {
            if (status != Status.Ok)
            {
                throw new ClientException(message);
            }
        }

        private ClientException WrapException(Exception e)
        {
            return new ClientException(e.Message, e);
        }
    }
}