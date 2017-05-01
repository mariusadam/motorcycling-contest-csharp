using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Generated;

namespace MotorcyclingContestApp.Domain
{
    public class Converter
    {
        //public ToDto()
        public Team ToPoco(TeamDto teamDto)
        {
            return new Team
            {
                Id = teamDto.Id,
                Name = teamDto.Name
            };
        }

        internal EngineCapacity ToPoco(EngineCapacityDto ecDto)
        {
            return new EngineCapacity
            {
                Id = ecDto.Id,
                Capacity = ecDto.Capacity
            };
        }

        public RaceDto ToDto(Race race)
        {
            return new RaceDto
            {
                Id = race.Id,
                Name = race.Name,
                StartTime = race.StarTime.Ticks
            };
        }

        public EngineCapacityDto ToDto(EngineCapacity ec)
        {
            return new EngineCapacityDto
            {
                Id = ec.Id,
                Capacity = ec.Capacity
            };
        }

        public TeamDto ToDto(Team team)
        {
            return new TeamDto
            {
                Id = team.Id,
                Name = team.Name
            };
        }

        internal Race ToPoco(RaceDto r)
        {
            return new Race
            {
                Id = r.Id,
                Name = r.Name,
                StarTime = new DateTime(r.StartTime)
            };
        }
    }
}