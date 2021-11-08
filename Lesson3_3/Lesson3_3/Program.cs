using System;

namespace Lesson3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a word that you want to see in the reverse character order:");
            string theWord = Console.ReadLine();
            char[] reverseWord = theWord.ToCharArray();


            Console.WriteLine("=================================================");
            Console.WriteLine("The reverse character order of your word will be:");
            for (int i = reverseWord.Length-1; i >= 0; i--)
            {
                Console.Write(reverseWord[i]+" ");
            }

        }
    }
}
