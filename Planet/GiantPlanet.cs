using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planet
{
    class GiantPlanet : Planet, IHasMoons, IHasRings
    {
        //Private instance variables
        private string _type;

        //Constructor    <- values inhereted from the Planet class ->                
        public GiantPlanet(string name, double diameter, double mass, string type) :base(name, diameter, mass)
        {
            this._type = type;
        }

        public bool HasMoons()
        {
            if (MoonCount > 0)
            {
                return true;
            }
            else
                return false;
        }

        public bool HasRings()
        {
            if (RingCount > 0)
            {
                return true;
            }
            else
                return false;
        }
        public override void LookAt()
        {
            Console.WriteLine("I see a giant planet");
        }
        public void LookAt(int Distance)
        {
            Console.WriteLine("I see a giant planet from far away");
        }

    }
}
