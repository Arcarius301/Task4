using System;
using System.Collections.Generic;
using System.Text;

namespace Task4
{
    public static class ArrayTools
    {
        public static int[] Generate(int length, int min, int max)
        {
            Random rnd = new Random();
            int[] arr = new int[length];
            for (int i = 0; i <= length - 1; i++)
            {
                arr[i] = rnd.Next(min, max);
            }

            return arr;
        }

        public static (int[], int[]) SplitByParity(int[] arr)
        {
            List<int> evenNumbersList = new List<int>();
            List<int> oddNumbersList = new List<int>();
            for (int i = 0; i <= arr.Length - 1; i++)
            {
                if ((arr[i] & 1) == 0)
                {
                    evenNumbersList.Add(arr[i]);
                }
                else
                {
                    oddNumbersList.Add(arr[i]);
                }
            }

            if (evenNumbersList.Count == 0 || oddNumbersList.Count == 0)
            {
                throw new ArgumentException("Array should contain both odd and even values");
            }

            return (evenNumbersList.ToArray(), oddNumbersList.ToArray());
        }

        public static char[] GetAlphabetAccordance(int[] arr)
        {
            char[] charArr = new char[arr.Length];
            for (int i = 0; i <= arr.Length - 1; i++)
            {
                if (arr[i] <= 0 || arr[i] >= 27)
                {
                    throw new ArgumentOutOfRangeException("All array values should be between 1 and 26, inclusive.");
                }

                charArr[i] = (char)(arr[i] + 96);
            }

            return charArr;
        }

        public static char[] ToUpper(char[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (char.IsLetter(arr[i]))
                {
                    arr[i] = char.ToUpperInvariant(arr[i]);
                }
            }

            return arr;
        }

        public static char[] ToUpper(char[] arr, char[] characters)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < characters.Length; j++)
                {
                    if (arr[i].Equals(characters[j]) && char.IsLetter(arr[i]))
                    {
                        arr[i] = char.ToUpperInvariant(arr[i]);
                        break;
                    }
                }
            }

            return arr;
        }

        public static int CountUppercaseCharacters(char[] arr)
        {
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == char.ToUpperInvariant(arr[i]) && char.IsLetter(arr[i]))
                {
                    count++;
                }
            }

            return count;
        }

        public static int CountUppercaseCharacters(char[] arr, char[] characters)
        {
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < characters.Length; j++)
                {
                    if (char.ToLowerInvariant(arr[i]).Equals(char.ToLowerInvariant(characters[j])))
                    {
                        if (arr[i] == char.ToUpperInvariant(arr[i]) && char.IsLetter(arr[i]))
                        {
                            count++;
                        }

                        break;
                    }
                }
            }

            return count;
        }
    }
}