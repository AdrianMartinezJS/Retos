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
            var tennisGame = new TennisMatch();
            var P1WinnsFiveToThree = new string[8] { "P1", "P1", "P2", "P2", "P1", "P2", "P1", "P1" };

            Console.WriteLine(tennisGame.printResult(P1WinnsFiveToThree));
            */

            /*
             * PrimeFibonacciEven
            var _numberToProof = new PrimeFibonacciAndEven();
            Console.WriteLine("Please enter a number to proof if it is prime or Fibonacci or pair (Must be a positive Number bigger than 0): ");
            var answer = Console.ReadLine();
            var result = _numberToProof.proof(Convert.ToInt32(answer));
            Console.WriteLine(result);
            */

            /* HogwartsHut
            var hogwartsHut = new HogwartsHut();
            var listOfAnswers = new List<string>();
            var numberOfQuestions = 5;
            for (int i = 0; i < numberOfQuestions; i++)
            {
                var questionAndPosibleAnswers = hogwartsHut.getQuestionAnswer(i);

                Console.WriteLine(questionAndPosibleAnswers[0]);
                Console.WriteLine("You have the following posibilities: (Just enter the number of your answer)");
                Console.WriteLine("1: {0}", questionAndPosibleAnswers[1]);
                Console.WriteLine("2: {0}", questionAndPosibleAnswers[2]);
                Console.WriteLine("3: {0}", questionAndPosibleAnswers[3]);
                Console.WriteLine("4: {0}", questionAndPosibleAnswers[4]);
                var answer = Console.ReadLine();
                if (!String.IsNullOrEmpty(answer))
                    listOfAnswers.Add(answer);
            }
            Console.WriteLine( hogwartsHut.selectProperHouse(listOfAnswers) );
            */
        }
    }
}