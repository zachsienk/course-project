using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Tower
    {
        private readonly MapLocation _location;
        private const int _range = 1;
        private const int _power = 1;

        private static readonly System.Random _random = new System.Random();
        private readonly MapLocation _locaiton;

        public Tower(MapLocation location)
        {
            _location = location;
           
        }

        public void FireOnInvaders(Invader[] invaders)
        {
            
            for (int i = 0; i < invaders.Length; i++)
            {
                Invader invader =  invaders [i];
            }

            foreach (Invader invader in invaders)
            {
                //do stuff with invader
                if(invader.IsActive && _location.InRangeOf(invader.Location, _range))
                {
                    invader.DecreaseHealth(_power);
                    break;
                }
            }
        }
        

    }
}
