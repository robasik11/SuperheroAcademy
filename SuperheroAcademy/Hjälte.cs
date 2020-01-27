using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperheroAcademy
{
    class Hjälte
    {
        public int hp = 100;
        public int knowledge = 100;
        public int power = 100;
        public string name;

        public void Printstats(Hjälte target)
        {

            Console.WriteLine("Your hero " + target.name + " has\n " + target.hp + " hp " + target.power + " power\n " + target.knowledge + (" knowledge"));
        }

        public void Name()
        {

            name = Console.ReadLine();

            if (name.Length < 2)
            {
                Console.Clear();
                Console.WriteLine("You need a name..");
                Name();

            }
        }
    }
}