using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planet
{
    class TerrestrialPlanet : Planet, IHasMoons, IHabitable
    {
        private bool _oxygen;

        public TerrestrialPlanet(string name, double diameter, double mass, bool oxygen) :base(name, diameter, mass)
        {
            this._oxygen = oxygen;
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

        public bool Habitable()
        {
            return this._oxygen;
        }
        public override void LookAt()
        {
            Console.WriteLine("hi");
        }
        public void Absorb(Planet planet)
        {
            Console.WriteLine("eating " + planet.Name);
        }
    }
}
