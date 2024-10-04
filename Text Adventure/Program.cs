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
                input = Console.ReadLine();
                if (input == "Hop")
                {
                    Console.WriteLine("You use the wall to get on your last remaining foot. And you begin to hop to the cell door.");
                    Console.WriteLine("As you hop through the cell's door you begin to hear rapid foot steps." +
                        "You turn around and you see a dog-like creature rushing towards you. You attempt to hop away from the creature." +
                        "But you tripped during your attempted escape, and the creature now has begun to dig into your flesh.");
                    Console.WriteLine("You died");
                }
                else if (input == "Crawl")
                {
                    Console.WriteLine("You turn over onto your stomach, and use your arms the propell yourself forward to the cell door.");
                    Console.WriteLine("You make it out of the cell, though your body fails you due to your body in a exterme form of decay.");
                    Console.WriteLine("As you lie on the floor of the hallway you begin to hear foot steps increasing in speed.");
                    Console.WriteLine("You see a dog-like creature rushing to you, with hunger in its eyes.");
                    Console.WriteLine("It plunges its teeth into you, and it rips you apart.");
                    Console.WriteLine("You died");
                }
            }
            else if (input == "Call Out")
            {
                Console.WriteLine("You yell out for help, and there is no response at first. But a key is thrown to you from the dark hallway outside of the cell.");
                Console.WriteLine("After you get your foot out of the chain, you can now go to the cell door.");

                Console.WriteLine("What do you want to do now?");
                Console.WriteLine("> Look Around");
                Console.WriteLine("> Walk Out");
                input = Console.ReadLine();
                if (input == "Look Around")
                {
                    Console.WriteLine("You look around the cell, you see that it is made of some sort of stone. The cell was extermly small.");
                    Console.WriteLine("But you do notice a skeleton in a corner while looking around.");
                    Console.WriteLine("The skeleton look to be a couple centuries old, due to the uniform being from Black Steel Age.");

                    Console.WriteLine(" Do you want to check out the skeleton or leave?");
                    Console.WriteLine("> Check Out Skeleton");
                    Console.WriteLine("> Leave Cell");

                    input = Console.ReadLine();
                    if (input == "Check Out Skeleton")
                    {
                        Console.WriteLine("You walk to the skeleton in the cornor, you determine it was a soldier from the Aurora Protectorate.");
                        Console.WriteLine("The skeleton has standard light armor and a short sword. Though both pieces equipment are in a serve state of rusting.");
                        Console.WriteLine("Since your body is in a exterme form of decay so you can't carry much.");
                    }
                    else if (input == "Leave Cell")
                    {
                        Console.WriteLine("You determine that the gear of the skeleton is far too rusted to be of use");
                        Console.WriteLine("So you turn around to the cell door and walk through it.");
                        Console.WriteLine("Once you are out of the cell you look around there are a path leading right and one leading left.");
                    }
                }
                else if (input == "Walk Out")
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
