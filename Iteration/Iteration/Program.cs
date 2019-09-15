using System;
using System.Collections.Generic;


namespace Iteration
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //#1
            string[] groceries = new string[5];
            groceries[0] = "bread";
            groceries[1] = "eggs";
            groceries[2] = "milk";
            groceries[3] = "apples";

            Console.WriteLine("Here is a list of groceries to purchase: " + groceries[0] + ", " + groceries[1] + ", "
                + groceries[2] + ", " + groceries[3] + ".");
            Console.WriteLine("Please add an item to the list.");
            for (int j = 4; j < 5; j++)
            {
                groceries[j] = Console.ReadLine();
            }
            Console.WriteLine("Here is our final grocery list:");
            for (int j = 0; j < groceries.Length; j++)
            {
                Console.WriteLine(groceries[j]);
            }


            //infite loop, #2:

            //for (int i = 0; ; i++)
            //{
            //    console.writeline("i like pie!");
            //}

            //fixed loop (counts for both #3 and #4 of the assignment):

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("I like pie!");
            }

            //#5
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }

            //#6, #7, and #8
            List<string> clothing = new List<string>();
            clothing.Add("scarf");
            clothing.Add("sweater");
            clothing.Add("jacket");
            clothing.Add("monacle");
            clothing.Add("shirt");
            clothing.Add("hat");
            Console.WriteLine("Type in an item of clothing to see if it is in my list.");
            string fashion = Console.ReadLine();
            for (int i = 0; i < clothing.Count; i++)
            {
                if (fashion == clothing[i])
                {
                    Console.WriteLine("Yep, a " + fashion + " is index number " + i + " on the list of " +
                        "items i need to buy for my corgi!");
                    break;
                }
                else if (!clothing.Contains(fashion))
                {
                    Console.WriteLine("Nope, that is not an item i need to buy.");
                    break;
                }
            }

            //#9 and #10
            List<string> pets = new List<string>();
            pets.Add("dog");
            pets.Add("cat");
            pets.Add("pig");
            pets.Add("parakeet");
            pets.Add("dog");
            pets.Add("hedgehog");
            Console.WriteLine("What kind of pet would you like?  i might have one to sell you.");
            string cutie = Console.ReadLine();
            for (int i = 0; i < pets.Count; i++)
            {
                if (cutie == pets[i])
                {
                    Console.WriteLine("Yes, a " + cutie + " is index number " + i + " on my list of pets i can sell you!");
                }
                else if (!pets.Contains(cutie))
                {
                    Console.WriteLine("Nope, i am not selling any of those right now.");
                    break;
                }
            }

            //#11
            List<string> boardGames = new List<string>();
            boardGames.Add("Battle For Rokugan");
            boardGames.Add("Dead Of Winter");
            boardGames.Add("Codenames");
            boardGames.Add("Mansions Of Madness");
            boardGames.Add("Time Stories");
            boardGames.Add("Battle For Rokugan");
            Console.WriteLine("Please pick a board game to see if it is on my list of ones I own.");
            string game = Console.ReadLine();
            int q = 0;
            foreach (string board in boardGames)
            {
                if (game == board && q == 0)
                {
                    Console.WriteLine("Yes, I own that board game!");
                    q++;
                }
                else if (game == board && q == 1)
                {
                    Console.WriteLine("Oops, looks like I have two of those on my list!");
                    break;
                }
                else if (!boardGames.Contains(game))
                {
                    Console.WriteLine("Nope, I do not own that board game.");
                    break;
                }
            }

            Console.ReadLine();

         










        }
    }
}
