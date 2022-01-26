using System;

namespace CSharp_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            // Players Guess

            Console.Write("Guess A Number Between 1 And 6\n");
            string player_guess;
            Console.Write("Please Enter Your Guess: ");
            player_guess = Console.ReadLine();

            // Check Guess Parameters
            if (Convert.ToInt16(player_guess) < 7 && Convert.ToInt16(player_guess) > 0)
            {
                // Dice Roll
                int min = 1;
                int max = 6;

                Random dice = new Random();
                int dice_roll = dice.Next(min, max);

                Console.WriteLine("The Dice Rolled A " + dice_roll);


                //Was Guess Correct
                if (Convert.ToInt16(player_guess) == dice_roll)
                {
                    Console.WriteLine("Your Guess Was Correct");

                    //Double Or Nothing
                    string guess_again;
                    Console.WriteLine("Would You Like To Guess Again? Answer 'yes' or 'no'\n");
                    guess_again = Console.ReadLine();

                    if (guess_again.ToLower() == "yes")
                    {
                        //Game Two
                        Console.WriteLine("Another Dice Will Be Rolled And Added To The Precious Roll\n You Must Guess If The Total Is Odd Or Even");
                        string player_guess2;
                        Console.Write("Please Enter Your Guess: ");
                        player_guess2 = Console.ReadLine();

                        //Roll 2
                        int dice_roll2 = dice.Next(min, max);
                        Console.WriteLine("The Dice Rolled A " + dice_roll2);
                        int total = dice_roll + dice_roll2;
                        Console.WriteLine("The Total Was " + total);

                        string result;
                        //Odd Or Even
                        if (total % 2 == 0)
                        {
                            result = ("even");
                        }
                        else result = ("odd");

                        //Guess Correct
                        if (player_guess2.ToLower() == result)
                        {
                            Console.WriteLine("Your Guess Was Correct");
                        }
                        else Console.WriteLine("Your Guess Was Incorrect");
                    }
                    else Console.WriteLine("Okay");
                }
                else Console.WriteLine("Your Guess Was Incorrect");
            }
            else Console.WriteLine("Invalid Guess");


            
        }
    }
}
