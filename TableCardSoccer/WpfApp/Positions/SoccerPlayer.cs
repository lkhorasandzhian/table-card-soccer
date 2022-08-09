using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp.Positions
{
    internal class SoccerPlayer
    {
        private uint _shoot;
        private uint _pass;
        private uint _defence;
        private uint _stamina;

        public uint Shoot { get { return _shoot; }}
        public uint Pass { get { return _pass; }}
        public uint Defence { get { return _defence; }}
        public uint Stamina { get { return _stamina; }}
    }
}
