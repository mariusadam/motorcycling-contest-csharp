using System;
using System.Collections.Generic;
using MotorcyclingContestApp.Domain;

namespace MotorcyclingContestApp.Client
{
    public interface IClientProxy
    {
        void Subscribe(IEnumerable<EventName> eventsNames, Action<Domain.Event> eventsHandler);
        void Login(string email, string password);
        IEnumerable<Contestant> GetContestants();
        IEnumerable<Contestant> SearchContestatns(string teamName);
        IEnumerable<Race> GetRaces();

        void RegisterContestant(string contestantName, Team team, EngineCapacity ec,
            IEnumerable<Race> races);

        IEnumerable<Team> GetTeams();
        IEnumerable<EngineCapacity> GetEngineCapacities();
        void AddTeam(string teamName);
        void GetRacesParticipants(Action<Race, int> addRaceDelegate);
    }
}