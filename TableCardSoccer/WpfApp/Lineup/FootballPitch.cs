using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp.Positions;

namespace WpfApp.Lineup
{
    public class FootballPitch
    {
        public Lineup FirstTeam { get; private set; }
        public Lineup SecondTeam { get; private set; }
        public SoccerPlayer ActivePlayer { get; private set; }
        public (int First, int Second) Scores { get; private set; }
        public DateTime StartTime { get; private set; }
        public DateTime FinishTime { get; private set; }

        private static Random randomizer = new Random();

        public FootballPitch(Lineup _first, Lineup _second)
        {
            FirstTeam = _first;
            SecondTeam = _second;
            if (randomizer.NextDouble() > 0.5)
            {
                ActivePlayer = _first.Midfielders[randomizer.Next(0, _first.Midfielders.Count())];
            }
            else
            {
                ActivePlayer = _second.Midfielders[randomizer.Next(0, _second.Midfielders.Count())];
            }
            Scores = (0, 0);
            StartTime = DateTime.Now;
            FinishTime = StartTime + new TimeSpan(0, 10, 0);
        }


    }
}
