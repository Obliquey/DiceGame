using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGuessingGame {
    class Program {
        static void Main(string[] args) {
            Random r = new Random();

            int winNum = r.Next(0, 100);

            bool win = false;

            do {
                Console.Write("Guess a number inbetween 0 and 100: ");
                string s = Console.ReadLine();

                int userGuess = int.Parse(s);
                if(userGuess > winNum){
                    Console.WriteLine("Too high! Guess lower....");
                } else if (userGuess < winNum) {
                    Console.WriteLine("Gotta guess a little higher!");
                } else if (userGuess == winNum){
                    Console.WriteLine("Heyyyyy you got it! Congratulations!");
                    win = true;
                }
                Console.WriteLine();
            } while (win == false);
            Console.WriteLine("Thank you for playing!");
            Console.Write("Press any key to finish.");
            Console.ReadKey(true);
        }
    }
}