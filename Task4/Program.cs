using System;
using System.Collections.Generic;

namespace Task4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int length;
            do
            {
                Console.Write("Enter the length of an array (between 10 and 100): ");
                if (int.TryParse(Console.ReadLine(), out length) && length >= 10 && length <= 100)
                {
                    break;
                }

                Console.WriteLine("Please enter the correct number");
            }
            while (true);

            int[] arr = ArrayTools.Generate(length, 1, 27);
            (int[], int[]) separatedArrays = ArrayTools.SplitByParity(arr);
            char[] filter = new char[] { 'a', 'e', 'i', 'd', 'h', 'j' };
            char[] arr1 = ArrayTools.ToUpper(ArrayTools.GetAlphabetAccordance(separatedArrays.Item1), filter);
            char[] arr2 = ArrayTools.ToUpper(ArrayTools.GetAlphabetAccordance(separatedArrays.Item2), filter);
            int count1 = ArrayTools.CountUppercaseCharacters(arr1, filter);
            int count2 = ArrayTools.CountUppercaseCharacters(arr2, filter);

            Console.WriteLine("\nGenerated array: " + string.Join(' ', arr));
            Console.WriteLine($"First array contains {separatedArrays.Item1.Length} values (even): " + string.Join(' ', separatedArrays.Item1));
            Console.WriteLine($"Second array contains {separatedArrays.Item2.Length} values (odd): " + string.Join(' ', separatedArrays.Item2));
            Console.WriteLine($"First array after modification: " + string.Join(' ', arr1));
            Console.WriteLine($"Second array after modification: " + string.Join(' ', arr2));

            if (count1 > count2)
            {
                Console.Write("First array contains more uppercase characters: ");
            }
            else if (count1 < count2)
            {
                Console.Write("Second array contains more uppercase characters: ");
            }
            else
            {
                Console.Write("Arrays contain the same amount uppercase characters: ");
            }

            Console.WriteLine($"1) {count1} 2) {count2}");
            Console.ReadKey();
        }
    }
}
