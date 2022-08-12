using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp.Positions;

namespace WpfApp.Lineup
{
    public class Lineup
    {
        private Goalkeeper _goalkeeper;
        private List<Defender> _defenders;
        private List<Midfielder> _midfielders;
        private List<Forward> _forwards;

        public Goalkeeper Goalkeeper
        {
            get => _goalkeeper;
            set
            {
                if (_countOfSubstitution <= 0)
                    return;
                _countOfSubstitution--;
                _goalkeeper = value;
            }
        }

        public List<Defender> Defenders
        {
            get => _defenders;
            set
            {
                if (_countOfSubstitution <= 0 || value.Intersect(_defenders).Count() > _countOfSubstitution)
                    return;
                _countOfSubstitution -= value.Intersect(_defenders).Count();
                _defenders = value;
            }
        }

        public List<Midfielder> Midfielders
        {
            get => _midfielders;
            set
            {
                if (_countOfSubstitution <= 0 || value.Intersect(_midfielders).Count() > _countOfSubstitution)
                    return;
                _countOfSubstitution -= value.Intersect(_midfielders).Count();
                _midfielders = value;
            }
        }

        public List <Forward> Forwards
        {
            get => _forwards;
            set
            {
                if (_countOfSubstitution <= 0 || value.Intersect(_forwards).Count() > _countOfSubstitution)
                    return;
                _countOfSubstitution -= value.Intersect(_forwards).Count();
                _forwards = value;
            }
        }

        private int _countOfSubstitution = 3;
        private readonly List<(int, int, int)> tactics = new List<(int, int, int)> { (5, 3, 2), (4, 4, 2), (4, 3, 3) };

        public Lineup(Goalkeeper goalkeeper, List<Defender> defenders, List<Midfielder> midfielders, List<Forward> forwards, int countOfSubstitution)
        {
            if (!tactics.Contains((defenders.Count(), midfielders.Count(), forwards.Count())))
            {
                throw new ArgumentException("Wrong amount of football players");
            }
            _goalkeeper = goalkeeper;
            _defenders = defenders;
            _midfielders = midfielders;
            _forwards = forwards;
        }
    }
}
