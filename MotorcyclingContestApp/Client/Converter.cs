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

        public Generated.Event.Types.Name ToDto(EventName evName)
        {
            switch (evName)
            {
                case EventName.ContestantRegistered:
                    return Generated.Event.Types.Name.ContestantRegistered;
                case EventName.TeamAdded:
                    return Generated.Event.Types.Name.TeamAdded;
                default:
                    throw new ArgumentOutOfRangeException(nameof(evName), evName, null);
            }
        }

        public Event ToPoco(Generated.Event e)
        {
            switch (e.Name)
            {
                case Generated.Event.Types.Name.ContestantRegistered:
                    return new Event
                    {
                        Name = EventName.ContestantRegistered
                    };
                case Generated.Event.Types.Name.TeamAdded:
                    return new Event
                    {
                        Name = EventName.TeamAdded
                    };
                default:
                    throw new ArgumentOutOfRangeException();
            }
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

        public Contestant ToPoco(ContestantDto contestantDto)
        {
            return new Contestant
            {
                Id = contestantDto.Id,
                EngineCapacity = ToPoco(contestantDto.EngineCapacity),
                Name = contestantDto.Name,
                Team = ToPoco(contestantDto.Team)
            };
        }
    }
}