using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Invader
    {
        //path object variable to make sure invador uses the path
        private readonly Path _path;
        //variable to have invador move down path
        private int _pathstep = 0;

        //properties getter and setter (computed property)  => is used to remove the get/set
        public MapLocation Location => _path.GetLocationAt(_pathstep);

        public bool HasScored { get { return _pathstep >= _path.Length; } }
        
        public bool IsNutralized => Health <= 0;

        public bool IsActive => !(IsNutralized) || HasScored;

        public int Health { get; set; } = 2;

        //constructor
        public Invader(Path path)
        {

            _path = path;

        }


        //method to have invader move 
        public void Move()=> _pathstep += 1;


        public void DecreaseHealth(int factor)
        {
            Health -= factor;
        }
        
    }
}
