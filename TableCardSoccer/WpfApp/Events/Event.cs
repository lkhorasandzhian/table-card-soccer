using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp.Positions;

namespace WpfApp.Events
{
    abstract public class Event
    {
        public SoccerPlayer CurrentPlayer { get; private set; }

        public Event(SoccerPlayer _player)
        {
            CurrentPlayer = _player;
        }
    }
}
