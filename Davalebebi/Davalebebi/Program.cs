using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Davalebebi
{
    class Program
    {
        static void Main(string[] args)
        {

            // string word;
            //word = Console.ReadLine();
            //Console.WriteLine(IsPalindrome(word));
            //Console.ReadLine();



            //int number;
            //number = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(minSplit(number));
            //Console.ReadLine();


           /* int[] array = new int[] { 1, 1, 1, 2, 8, 2, 3, 3, 3, 4, 5, 6, 6, 3, 4, 5, 6, 8, 9 };
            Console.WriteLine(notContains(array));
            Console.ReadLine();*/


            //string symbols = Console.ReadLine();
            //Console.WriteLine(isProperly(symbols));
            //Console.ReadLine();


            /*int count = 0;
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(CountVariants(number));
            Console.ReadLine();*/
        }

        public static bool IsPalindrome(string text)
        {
            if (text.Length <= 1)
                return true;
            else
            {
                if (text[0] != text[text.Length - 1])
                    return false;
                else
                    return IsPalindrome(text.Substring(1, text.Length - 2));
            }
        }
        public static int minSplit(int amount)
        {
            int p = 0;

            int[] array = new int[] { 1, 5, 10, 20, 50 };
            int _size = array.Length - 1;
            while (amount != 0)
            {
                int count = amount / array[_size];
                p += count;
                int newValue = amount % array[_size];
                amount = newValue;
                _size--;
            }
            return p;

        }

        public static int notContains(int[] array)
        {
            int p = 0;
            SortedSet<int> set = new SortedSet<int>();
            for (int i = 0; i < array.Length; i++)
            {
                set.Add(array[i]);
            }
            for (int i = 1; i < set.Count; i++)
            {
                if (set.Contains(i))
                {

                }
                else
                {
                    p = i;
                    break;
                }
            }
            return p;
        }

        public static Boolean isProperly(String sequence)
        {
            bool p = false;
            Stack stack = new Stack();
            if (stack.Count % 2 == 0)
            {
                for (int i = 0; i < sequence.Length; i++)
                {
                    if (stack.Count == 0)
                    {
                        stack.Push(sequence[i]);
                        continue;
                    }
                    if (sequence[i] == '(')
                    {
                        stack.Push(sequence[i]);

                    }
                    if (sequence[i] == ')' && stack.Peek().Equals('('))
                    {
                        stack.Pop();
                    }


                }
                if (stack.Count == 0)
                    return p=true;

                else
                {
                    return p ;
                }
            }
            return p;
        }

        public static int CountVariants(int n)
        {

            if (n == 0)
            {
                return 1;
            }
            else if (n < 0)
            {
                return 0;
            }
            else
            {
                return CountVariants(n - 2) + CountVariants(n - 1);
            }
        }
    }
}

