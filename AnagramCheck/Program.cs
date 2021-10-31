using System;

namespace AnagramCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            // Take in input of two different words
            Console.WriteLine("Kindly input your first word");
            string firstInput = Console.ReadLine();

            Console.WriteLine("Kindly input your second word");
            string secondInput = Console.ReadLine();

            // Save the inputs into Arrays
            char[] firstWord = firstInput.ToLower().ToCharArray();
            char[] secondWord = secondInput.ToLower().ToCharArray();

            // Save the Arrays
            Array.Sort(firstWord);
            Array.Sort(secondWord);

            // Convert the Character arrrays into texts
            string SortedFirstWord = new string(firstWord);
            string SortedSecondWord = new string(secondWord);

            // Compare both words and send out the output
            if (SortedFirstWord == SortedSecondWord)
            {
                Console.WriteLine($"{firstInput} and {secondInput} have the same letter composition, hence they are anagrams");
            }
            else
            {
                Console.WriteLine($"{firstInput} and {secondInput} do not have the same letter composition, hence they are not anagrams");
            }
        }
    }
}
