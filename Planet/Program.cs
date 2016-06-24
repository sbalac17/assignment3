using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planet
{
    class Program
    {
        static void Main(string[] args)
        {
            //Planet planet1 = new Planet("Saturn", 200.00, 100.00);
            //Console.WriteLine(planet1.ToString()); (not supposed to put new planet because its an abstract class)
            //planet1.Name = "Jupiter";         //changing the property
            //Console.WriteLine(planet1.Name);  //getting the property value

            GiantPlanet gPlanet = new GiantPlanet("Pluto", 200.00, 100.00, "Ice");
            Console.WriteLine(gPlanet.ToString());

            TerrestrialPlanet tPlanet = new TerrestrialPlanet("Earth", 400.00, 200.00, true);
            Console.WriteLine(tPlanet.ToString());
            gPlanet.LookAt();
            tPlanet.LookAt();
            gPlanet.LookAt(1); // this is overloaded method call


            tPlanet.Absorb(gPlanet); // this is passing an object with method

            //Planet p = gPlanet;
            // p.LookAt(); (calling an abstract method) 

            /*Planet p = tPlanet;
            if (p is IHabitable)
            {
                IHabitable h = (IHabitable)p; this is casting(converting... converts a planet to an ihabitable)
                Console.WriteLine(h.Habitable());
            }
            else
            {
                Console.WriteLine("aaa");
            }
            (use this to know if something has an interface...) 
            */

            WaitForAnyKey();

            /*List<string> myList = new List<string>();
            myList.Add("item1");
            myList.Add("item2");
            myList.Add("item3");
            myList.Add("item4");
            myList.Remove("item2");

            foreach (string item in myList)
            {
                Console.WriteLine(item);
                //if you are using a list of objects then you need to put item.Name
                //to be able to see the name of the item Console.WriteLine(item.Name); 
            }

            List<Planet> newList = new List<Planet>();
            newList.Add(planet1);

            foreach (Planet item in newList)
            {
                Console.WriteLine(item.Name); //Console.WriteLine(item) gives you the .ToString() output
            }
            

            /*/
            /*Random number generator
            Random randomNumber = new Random();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(randomNumber.Next(10));    //Random values from 0-9
                Console.WriteLine(randomNumber.Next(6) + 5); //Random values from 5-10
            }*/

        }
       public static void WaitForAnyKey()
        {
            Console.ReadKey();
        }
    }

}
