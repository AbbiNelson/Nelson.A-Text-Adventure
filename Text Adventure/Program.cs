using System.IO;
using System.Runtime.Intrinsics.X86;

namespace Text_Adventure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Your eyes slowly open. You look around, you see that the it is a damp cell. The cell must be far from the surface.");
            Console.WriteLine("You see the cell door is open, you attempet to move but you can't. You look down and you see that your foot is chained.");

            Console.WriteLine("How do you want to escape the cell?");
            Console.WriteLine("> Break Foot");
            Console.WriteLine("> Call Out");

            string input = Console.ReadLine();
            if (input == "Break Foot")
            {
                Console.WriteLine("You pick up a a near by rock. And Begin to smash it against your foot. After five blows breaks your foot.");
                Console.WriteLine("After you get your foot out of the chain, you now need to find a way to the cell door.");

                Console.WriteLine("How do you want to reach the cell door?");
                Console.WriteLine("> Hop");
                Console.WriteLine("> Crawl");
                string inoutput = Console.ReadLine();
                if (inoutput == "Hop")
                {
                    Console.WriteLine("You use the wall to get on your last remaining foot. And you begin to hop to the cell door.");
                }
                else if (inoutput == "Crawl")
                {
                    Console.WriteLine("You turn over onto your stomach, and use your arms the propell yourself forward to the cell door.");
                }
            }
            else if (input == "Call Out")
            {
                Console.WriteLine("You yell out for help, and there is no response at first. But a key is thrown to you from the dark hallway outside of the cell.");
                Console.WriteLine("After you get your foot out of the chain, you can now go to the cell door.");

                Console.WriteLine("What do you want to do now?");
                Console.WriteLine("> Look Around");
                Console.WriteLine("> Walk Out");
                string inoutput = Console.ReadLine();
                if (inoutput == "Look Around")
                {
                    Console.WriteLine("You look around the cell, you see that it is made of some sort of stone. The cell was extermly small.");
                    Console.WriteLine("But you do notice a skeleton in a corner while looking around.");
                    Console.WriteLine("The skeleton look to be a couple centuries old, due to the uniform being from Black Steel Age.");
                }
                else if (inoutput == "Walk Out")
                {
                    Console.WriteLine("You turn to the door and begin walking to the cell door.");
                    Console.WriteLine("Once you are out of the cell you look around there are a path leading right and one leading left.");
                }
            }
            else
            {
                Console.WriteLine("Invalid option");
            }

        }
    }
}
