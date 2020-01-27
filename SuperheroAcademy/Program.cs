using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperheroAcademy
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            Hjälte H = new Hjälte();
            VattenHjälte VH = new VattenHjälte();
            EldHjälte EH = new EldHjälte();
            Jordhjälte JH = new Jordhjälte();
            Input I = new Input();

            Console.WriteLine("What is your name?");
            H.Name();
            Console.WriteLine("What is your type of element?");
            Console.ReadLine();
            Console.Clear();

            //
            int index = Input.Element();
            if (index == 0)
            {


                Console.WriteLine("Fire");
            }

            if (index == 1)
            {
                Console.WriteLine("Water");
            }
            if (index == 2)
            {
                Console.WriteLine("Earth");
            }


        }
    }
}
