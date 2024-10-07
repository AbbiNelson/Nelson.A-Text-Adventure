﻿using System.IO;
using System.Runtime.Intrinsics.X86;

namespace Text_Adventure
{
    
    internal class Program
    {  
        public enum equipmenttype
        {
            RustedArmor, RustedSword
        }

        static equipmenttype playerequip;
        // Below this is the Break Foot path, this is not meant to be survivable. And main reason why is that I didn't want to write a storyline based on the broken foot
        static void BreakFoot()
        {
            Console.WriteLine("You pick up a a near by rock. And Begin to smash it against your foot. After five blows breaks your foot." +
                                "After you get your foot out of the chain, you now need to find a way to the cell door.");

            Console.WriteLine("How do you want to reach the cell door?");
            Console.WriteLine("> Hop");
            Console.WriteLine("> Crawl");
            string input = Console.ReadLine();
            if (input == "Hop")
            {
                Console.WriteLine("You use the wall to get on your last remaining foot. And you begin to hop to the cell door." +
                    "As you hop through the cell's door you begin to hear rapid foot steps." +
                    "You turn around and you see a dog-like creature rushing towards you. You attempt to hop away from the creature." +
                    "But you tripped during your attempted escape, and the creature now has begun to dig into your flesh.");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("You died");
            }
            else if (input == "Crawl")
            {
                Console.WriteLine("You turn over onto your stomach, and use your arms the propell yourself forward to the cell door." +
                    "You make it out of the cell, though your body fails you due to your body in a exterme form of decay." +
                    "As you lie on the floor of the hallway you begin to hear foot steps increasing in speed." +
                    "You see a dog-like creature rushing to you, with hunger in its eyes." +
                    "It plunges its teeth into you, and it rips you apart.");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("You died");
            }
        }



        // This is the main path for the story. And also has the majority of lore in this path. 
        // Planning to make this pathway to the stop around when you get to the floor above yours.
        static void CallOut()
        {
            string name = "power";           
            int[] power = [5, 10, 15];

            Console.WriteLine("You yell out for help, and there is no response at first. But a key is thrown to you from the dark hallway outside of the cell." +
                    "After you get your foot out of the chain, you can now go to the cell door.");

            Console.WriteLine("What do you want to do now?");
            Console.WriteLine("> Look Around");
            Console.WriteLine("> Walk Out");
            string input = Console.ReadLine();
            if (input == "Look Around")
            {
                Console.WriteLine("You look around the cell, you see that it is made of some sort of stone. The cell was extermly small." +
                    "But you do notice a skeleton in a corner while looking around." +
                    "The skeleton look to be a couple centuries old, due to the uniform being from Black Steel Age.");

                Console.WriteLine(" Do you want to check out the skeleton or leave?");
                Console.WriteLine("> Check Out Skeleton");
                Console.WriteLine("> Leave Cell");

                input = Console.ReadLine();
                if (input == "Check Out Skeleton")
                {
                    Console.WriteLine("You walk to the skeleton in the cornor, you determine it was a soldier from the Aurora Protectorate." +
                        "The skeleton has standard light armor and a short sword. Though both pieces equipment are in a serve state of rusting." +
                        "Since your body is in a exterme form of decay so you can't carry much.");
                    Console.WriteLine("Which piece equipment will you take?");
                    Console.WriteLine("> Rusted Armor");
                    Console.WriteLine("> Rusted Sword");

                    input = Console.ReadLine();
                    if (input == "Rusted Armor")
                    {
                        Console.WriteLine("You begin to undo the armor straps and after struggling for a bit you are able to take the armor off." +
                            "After putting it on your body feels much heavier than before.");
                        playerequip = equipmenttype.RustedArmor;
                    }
                    else if (input == "Rusted Sword")
                    {
                        Console.WriteLine("You see the sword in the right hand of the skeleton." +
                            "You begin to tug at the sword, after a while you fall backwards. " +
                            "But you were able to get the sword at of the skeleton's hand");
                        playerequip = equipmenttype.RustedSword;
                    }
                }   
                else if (input == "Leave Cell")
                {
                    Console.WriteLine("You determine that the gear of the skeleton is far too rusted to be of use." +
                        "So you turn around to the cell door and walk through it." +
                        "Once you are out of the cell you look around there are a path leading right and one leading left.");
                }
                else if (input == "Walk Out")
                {
                    Console.WriteLine("You turn to the door and begin walking to the cell door." +
                        "Once you are out of the cell you look around there are a path leading right and one leading left.");
                }
            }

        }




        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;

            Console.WriteLine("Your eyes slowly open. You look around, you see that the it is a damp cell. The cell must be far from the surface." +
                "You see the cell door is open, you attempet to move but you can't. You look down and you see that your foot is chained.");

            Console.WriteLine("How do you want to escape the cell?");
            Console.WriteLine("> Break Foot");
            Console.WriteLine("> Call Out");

            string input = Console.ReadLine();
            if (input == "Break Foot")
            {
                BreakFoot();
            }
            else if (input == "Call Out")
            {
                CallOut();
            }
        }
    }
}
