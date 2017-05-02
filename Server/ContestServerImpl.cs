using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MotorcyclingContestApp.Domain;
using Services;

namespace Server
{
   public class ContestServerImpl : IContestServer
    {
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
    }
}
