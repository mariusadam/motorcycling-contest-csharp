using System.Collections.Generic;
using MotorcyclingContestApp.Domain;

namespace Services
{
    public interface IContestServer
    {
        void Login(string email, string password);
        void Subscribe(IEnumerable<EventName> eventNames);
        IList<Contestant> GetContestants();
        IList<Contestant> SearchContestants(string teamName);
        IList<Race> GetRaces();
        void RegisterContestant(string cname, Team team, EngineCapacity ec, IEnumerable<Race> races);
        IList<Team> GetTeams();
        IList<EngineCapacity> GetEngineCapacities();
        void AddTeam(string teamName);
        IList<Race> GetRacesParticipants();
    }
}
