using System;
using System.Text.RegularExpressions;
namespace ConsoleApplication2
{
    public class Program
    {
     

        public static void Main()
        {
            //           bool keepLooping = true;
            //while (keepLooping)
            //{
            NumberToWordsProgram program = new NumberToWordsProgram();
            Console.WriteLine("Input Number to Convert :");
            string input = Console.ReadLine();
            Console.WriteLine(program.ConvertToWords(input));
            Console.WriteLine("");
            //Console.WriteLine("Press Escape to End, Enter To Continue");
            //Console.WriteLine("");
            //if (Console.ReadKey().Key == ConsoleKey.Escape)
            //{
            //    keepLooping = false;
            //}
            //}
        }


    };

}

