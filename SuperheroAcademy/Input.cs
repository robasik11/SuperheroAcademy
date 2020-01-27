using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperheroAcademy
{
    class Input
    {
        //input arrays här 
        static string[] element = { " Fire", " Water", " Earth" };
        static int index = 0;

        public static int Element()
        {
            int index = 0;
            while (true)
            {
                for (int i = 0; i < element.Length; i++)
                {
                    string text = "";
                    if (index == i)
                        text += ">";
                    text += element[i];
                    Console.WriteLine(text);
                }
                

                //användaren endast behöver trycka med pilarna för att bläddra mellan mina olika alternativ i min array. 
                //Den räknar att första alternativet är 0 och den går upp oändligt MEN det är därför jag gjort if - satser längre ner för att stoppa "pekaren"
                ConsoleKeyInfo input = Console.ReadKey(); //här får man knapptryck från spelaren.
                if (input.Key == ConsoleKey.UpArrow) //är det -- så går pilen upp//ConsoleKeyInfo 
                    index--;
                if (input.Key == ConsoleKey.DownArrow) //++ gör så att pilen går ner istället
                    index++;
                if (input.Key == ConsoleKey.Enter)
                {

                    return index;
                }

                Console.Clear();
                if (index <= 0)
                {
                    index = 0;
                    Console.Clear();
                }



                if (index >= 2)

                {
                    index = 2;


                }
            }





        }
    }
}
