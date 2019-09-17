using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21Game
{
    class _21Game : Game, IWalkAway
    {
        public override void Play()
        {
            throw new NotImplementedException();
        }

        public override void listPlayers()
        {
            Console.WriteLine("21 Players:");
            base.listPlayers();
        }

        public void WalkAway (Player player)
        {
            throw new NotImplementedException();
        }
    }
}
