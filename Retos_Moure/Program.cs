using System;

namespace Retos_Moure
{
    public class Program
    {
        static void Main(string[] args)
        {
            /* FIZZBUZZ
            var fizzBuzz = new FizzBuzz();

            for (var numberToPrint = 1; numberToPrint <= 100; numberToPrint++) 
            {
                Console.WriteLine(fizzBuzz.checkForDivider(numberToPrint));
            }
            */

            /* HACKER Language
            var hackerLanguage = new HackerLanguage();
            Console.WriteLine("Insert a Text here to convert to Leef: ");
            var textToConvert = Console.ReadLine();

            Console.WriteLine(hackerLanguage.transformStringToLeet(textToConvert));
            */

            /* Tennis Game
            var P1 = new Player();
            var P2 = new Player();
            var tennisGame = new TennisMatch();
            var P1WinnsFiveToThree = new string[8] { "P1", "P1", "P2", "P2", "P1", "P2", "P1", "P1" };

            Console.WriteLine(tennisGame.printResult(P1WinnsFiveToThree));
            */

            var _numberToProof = new PrimeFibonacciAndEven();
            Console.WriteLine("Please enter a number to proof if it is prime or Fibonacci or pair (Must be a positive Number bigger than 0): ");
            var answer = Console.ReadLine();
            var result = _numberToProof.proof(Convert.ToInt32(answer));
            Console.WriteLine(result);
        }
    }
}