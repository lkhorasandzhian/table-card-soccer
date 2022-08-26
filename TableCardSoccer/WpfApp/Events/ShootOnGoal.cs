using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp.Positions;

namespace WpfApp.Events
{
    internal class ShootOnGoal : Event
    {
        public Goalkeeper goalkeeper { get; private set; }

        public ShootOnGoal(SoccerPlayer shooter, Goalkeeper keeper) : base(shooter)
        {
            goalkeeper = keeper;
        }
    }
}
