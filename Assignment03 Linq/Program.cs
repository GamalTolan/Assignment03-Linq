using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Assignment03_Linq.ListGenerators;
using static Assignment03_Linq.Customer;

namespace Assignment03_Linq
{
    internal class Program
    {

        static void Main(string[] args)
        {
            #region part01
            //01
            //var result = CustomerList.Where(c => c.City == "London").Take(3); // Washington مفيش حد في 

            //foreach (var customer in result)
            //{
            //    Console.WriteLine(customer);
            //}

            //02

            //var result = CustomerList.Where(c => c.City == "Washington").Skip(2); 

            //foreach (var customer in result)
            //{
            //    Console.WriteLine(customer);
            //}

            //03

            //int[] numbers= { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result = numbers.TakeWhile((num, index) => num > index);

            //Console.WriteLine(string.Join(", ", result));

            //04

            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var result = numbers.SkipWhile(num => num % 3 != 0); 

            //Console.WriteLine(string.Join(", ", result));

            //05

            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var result = numbers.SkipWhile((num, index) => num >= index); 

            //Console.WriteLine(string.Join(", ", result));


            #endregion

            #region part02
            //01

            //List<int> numbers = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };

            //var result = numbers.GroupBy(number => number % 5);

            //foreach (var group in result)
            //{
            //    Console.WriteLine($"Numbers with a remainder of {group.Key} when divided by 5:");
            //    foreach (var number in group)
            //    {
            //        Console.WriteLine(number);
            //    }

            //}

            //02

            //string[] words = System.IO.File.ReadAllLines("dictionary_english.txt");
            //var result = from word in words
            //             group word by word[0]
            //                   into wordGroup
            //             orderby wordGroup.Key
            //             select wordGroup.Take(10);

            //foreach (var group in result)
            //{
            //    Console.WriteLine($"Words that start with the same letter :");
            //    foreach (var word in group)
            //    {
            //        Console.WriteLine(word);
            //    }
            //}

            //03
            string[] Arr = { "from", "salt", "earn", "last", "near", "form" };

            var result = from word in Arr
                               group word by new string(word.OrderBy(c => c).ToArray())
                               into wordGroup
                               select wordGroup;

            foreach (var group in result)
            {
                
                foreach (var word in group)
                {
                    Console.WriteLine(word);
                }

                Console.WriteLine("======");

            }

            #endregion


        }
    }
}
