using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp.Positions
{
    internal class SoccerPlayer
    {
        protected static Random randomizer = new();

        protected uint _shoot;
        protected uint _pass;
        protected uint _tackle;
        protected uint _interception;
        protected uint _stamina;
        protected uint _endurance = 1000;

        public uint Shoot
        {
            get
            {
                return (uint)(_shoot * Math.Pow(Endurance / 1000, 0.09));
            }
            init
            {
                _shoot = value;
            }
        }
        public uint Pass
        {
            get
            {
                return (uint)(_pass * Math.Pow(Endurance / 1000, 0.03));
            }
            init
            {
                _pass = value;
            }
        }
        public uint Tackle
        {
            get
            {
                return (uint)(_tackle * Math.Pow(Endurance / 1000, 0.06));
            }
            init
            {
                _tackle = value;
            }
        }
        public uint Interception
        {
            get
            {
                return (uint)(_interception * Math.Pow(Endurance / 1000, 0.05));
            }
            init
            {
                _interception = value;
            }
        }
        public uint Stamina
        {
            get
            {
                return _stamina;
            }
            set
            {
                _stamina = value;
            }
        }
        public uint Endurance
        {
            get
            {
                return _endurance / 10;
            }
        }

        public bool PassTo(SoccerPlayer opponent)
        {
            _endurance -= 100 - Stamina;

            Func<double, double, double> passProbability = (x, y) => Math.Pow(1 / (1 + Math.Pow(Math.E, -((x - y) - 5) / 100)), 0.05);
            return passProbability(Pass, opponent.Interception) > 1.65 * randomizer.NextDouble();
        }

        public bool ShootOnGoal(Goalkeeper goalkeeper)
        {
            _endurance -= 100 - Stamina;

            Func<double, double, double> shootProbability = (x, y) => Math.Pow(1 / (1 + Math.Pow(Math.E, -((x - y) - 10) / 100)), 0.05);
            return shootProbability(Shoot, goalkeeper.Tackle) > 1.65 * randomizer.NextDouble();
        }
    }
}
