using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp.Positions;

namespace WpfApp.Events
{
    internal class Substitution : Event
    {
        public SoccerPlayer NewPlayer { get; private set; }

        public Substitution(SoccerPlayer oldPlayer, SoccerPlayer newPlayer) : base(oldPlayer)
        {
            NewPlayer = newPlayer;
        }
    }
}
