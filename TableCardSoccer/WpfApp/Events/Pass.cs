using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp.Positions;

namespace WpfApp.Events
{
    public class Pass : Event
    {
        public SoccerPlayer AcceptingPlayer { get; private set; }

        public Pass(SoccerPlayer _from, SoccerPlayer _to) : base(_from)
        {
            AcceptingPlayer = _to;
        }
    }
}
