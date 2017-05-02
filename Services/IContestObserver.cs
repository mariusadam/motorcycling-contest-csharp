using System;
using System.Collections.Generic;
using System.Text;
using MotorcyclingContestApp.Domain;

namespace Services
{
    public interface IContestObserver
    {
        void HandleEvent(Event e);
    }
}
