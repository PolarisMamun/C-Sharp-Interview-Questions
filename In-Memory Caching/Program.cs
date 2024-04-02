using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Generic;
using System.Linq;

namespace In_Memory_Caching
{
    public class Program
    {
        static void Main(string[] args)
        {
            IMemoryCache cache = new MemoryCache(new MemoryCacheOptions());
            PrimeNumbers primeNumbers = new PrimeNumbers(cache);

            int maxNumber = 100;

            IEnumerable<int> cachedPrimeNumbers = primeNumbers.GetPrimeNumbersUpTo(maxNumber);
            Console.WriteLine(cachedPrimeNumbers.Count());

            Console.WriteLine("Prime numbers up to " + maxNumber + ".");
            foreach(int primeNumber in cachedPrimeNumbers)
            {
                Console.WriteLine(primeNumber);
            }
            Console.ReadLine();

            Queue<int> queue = new Queue<int>();
            Stack<int> stack = new Stack<int>();
        }
    }
}
