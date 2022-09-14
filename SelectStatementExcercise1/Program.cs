// See https://aka.ms/new-console-template for more information
using System;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

namespace StatementExcercise
{
    class Program
    {
        #region Excercise1 if/else
        static void Main(string[] args)
        {
            Excercise Guessing Game
            var r = new Random();
            var favNumber = r.Next(1, 1000);
            int userInput;

            do
            {
                Console.WriteLine("Guess my favorite number from 1-1000");
                userInput = int.Parse(Console.ReadLine());

                if (userInput < favNumber)
                {

                    Console.WriteLine($"{userInput} is too low");
                }
                else if (userInput > favNumber)
                {

                    Console.WriteLine($"{userInput} is too high");
                }
                else
                {
                    Console.WriteLine("You're correct!!!");
                }
            } while (userInput != favNumber);
            #endregion

            #region Excercise 2 switchcase
            Console.WriteLine("What is your favorite school subject?");
            string subject = (Console.ReadLine());
            var favSubject = subject.ToLower();

            switch (favSubject)
            {
                case "math":
                case "calculus":
                case "algebra":
                    Console.WriteLine("I love math too.");
                    break;
                case "science":
                case "biology":
                case "physics":
                case "physiology":
                    Console.WriteLine("Science was my weakpoint.");
                    break;
                case "history":
                case "american history":
                case "world history":
                    Console.WriteLine("History is important, those who do not learn from history are doomed to repeat it.");
                    break;
                case "english":
                    Console.WriteLine("To be or not to be, what was my question again?");
                    break;
                case "music":
                    Console.WriteLine("Why?");
                    break;
                case "dance":
                    break;
                default:
                    Console.WriteLine("Good for you, I forgot the other ones but I love that subject too");
                    break;

#endregion
            }
        }
    }
}