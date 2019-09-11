using System;
using System.Collections.Generic;
using System.Linq;


namespace ArraysAndLists
{
    class Program
    {
        static void Main()
        {    
            //arrays and lists
           string[] weapons = new string[] {"banana ", "pillow ", "piece of tissue paper ", "magnifying glass ", "gym " +
                "membership card " };
            int[] combatants = new int[] { 7, 3, 21, 9, 13 };
            string[] winner = new string[] {"broken plunger ", " used bar of soap ", "cupcake with the frosting licked off ", "pair " +
                "of ill-fitting jeans ", "a half empty can of Axe bodyspray "};
            List<string> prizes = new List<string>(winner);
    
          
            Console.WriteLine("Choose a number from 0 to 4.");
            int deadly = Convert.ToInt32(Console.ReadLine());
            while (deadly > weapons.Length - 1 || deadly < 0)
            {
                Console.WriteLine("You have failed in your task.  Please try again.");
                deadly = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("You have chosen a " + weapons[deadly] + "to do battle with.  May the gods bless you with victory!");        
            

            Console.WriteLine("Now again choose a number from 0 to 4.");
            int warriors = Convert.ToInt32(Console.ReadLine());
            while (warriors > combatants.Length - 1 || warriors < 0)
            {
                Console.WriteLine("You have failed in your task.  Please try again.");
                warriors = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("You shall now face " + combatants[warriors] + " mutant wombats in a battle to the death!");


            Console.WriteLine("Now choose one final time a number from 0 to 4.");
            int lame = Convert.ToInt32(Console.ReadLine());
            while (lame > prizes.Count - 1 || lame < 0)
            {
                Console.WriteLine("You have failed in your task.  Please try again.");
                lame = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("If you should succeed in vanquishing your adversaries, you shall receive a " + prizes[lame] + "as " +
                "your reward!");
            Console.ReadLine();



        }
    }
}
