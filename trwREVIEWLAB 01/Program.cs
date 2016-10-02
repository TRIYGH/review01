//T. Robert Ward    8/24/14
//  Guess the number game - assignment #1-1

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            int [] guess = new int[3];
            int [] number = new int[] {3,5,5};
            int counter1 = 0;
            int counter2 = 0;
            int numCorrect = 0;
            string inputValue;
            bool theBigPrize = false;
            bool Done = false;
            //bool redo = false;
            bool stop = false;

            //Random numb = new Random();
            //number[0] = numb.Next(10);
            //number[1] = numb.Next(10);
            //number[2] = numb.Next(10);

            // to prevent duplicate numbers
            /*
            do
            {
                redo = false;
                if (number2 == number1 || number2 == number3)
                {
                    number2 = numb.Next(10);
                    redo = true;
                }
            } while (redo == true);

            do
            {
                redo = false;
                if (number3 == number1 || number3 == number2)
                {
                    number3 = numb.Next(10);
                    redo = true;
                }
            } while (redo == true);
            */

            Console.WriteLine();
            Console.WriteLine("*****  Lottery Game  *****");
            Console.WriteLine("\nPlease enter in 3 different guesses - ( a number between 0 and 9) ");

            Console.WriteLine(number[0] + "  " + number[1] + "  " + number[2] + "\n");

            Console.Write("\n\n");
            Console.Write("Enter Guess #1: ");
            inputValue = Console.ReadLine();
            guess[0] = int.Parse(inputValue);
            Console.Write("Enter Guess #2: ");
            inputValue = Console.ReadLine();
            guess[1] = int.Parse(inputValue);
            Console.Write("Enter Guess #3: ");
            inputValue = Console.ReadLine();
            guess[2] = int.Parse(inputValue);

            // Test $1,000,000
            if (guess[0] == number[0])
                if (guess[1] == number[1])
                    if (guess[2] == number[2])
                        theBigPrize = true;

            //Console.WriteLine(guess1 + " " + guess2 + " " + guess3);
            if (theBigPrize == true)
            {
                Console.WriteLine("Congratulations!!!!!! - You won $1,000,000");
                Done = true;
            
            }

            if (Done == false)
            {
                do
                {
                    do
                    {
                        if (guess[counter1] == number[counter2])
                        {
                            stop = true;
                            numCorrect++;
                        }
                        else counter2++;
                        if (counter2 == 3)
                            stop = true;
                    } while (stop == false);
                    stop = false;
                    counter1++;
                    counter2 = 0;
                } while (counter1 < 3);

              /*  if (guess[0] == guess[1] || guess[0] == guess[2] || guess[1] == guess[2])
                    if(number[0] == number[1] || number[0] == number[2] || number[1] == number[2])
                        numCorrect--;
                */
            
                switch (numCorrect)
                {
                    case 0: Console.WriteLine("You did not guess any of the numbers.\nYou Lose!!!\n\n");
                        break;

                    case 1: Console.WriteLine("You guessed 1 of the numbers - You win $10.\n\n");
                        break;

                    case 2: Console.WriteLine("Congrats - you guessed 2 of the numbers!  -  You win $100 !\n\n");
                        break;

                    case 3: Console.WriteLine("WOW!!!! you guessed all three numbers!!! - You win $1,000 !!!\n\n");
                        break;

                    default: Console.WriteLine("ERROR");
                        break;
                }
            }

            Console.WriteLine("Press ENTER to end.");
            inputValue = Console.ReadLine();
                        
        }
    }
}
