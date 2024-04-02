using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace In_Memory_Caching
{
    public class PrimeNumbers
    {
        private readonly IMemoryCache _cache;

        public PrimeNumbers(IMemoryCache cache)
        {
            _cache = cache;
        }

        public IEnumerable<int> GetPrimeNumbersUpTo(int maxNumber)
        {
            
            if(!_cache.TryGetValue(maxNumber,out IEnumerable<int> cashedResult))
            {
                cashedResult = GeneratePrimeNumbersUpTo(maxNumber);

                var cacheEntryOptions = new MemoryCacheEntryOptions { 
                    AbsoluteExpirationRelativeToNow = TimeSpan.FromHours(1)
                };
                _cache.Set(maxNumber, cashedResult, cacheEntryOptions);
            }
            return cashedResult;
        }
        private IEnumerable<int> GeneratePrimeNumbersUpTo(int maxNumber)
        {
            List<int> primeNumbers = new List<int>();

            for(int i = 2; i <= maxNumber; i++)
            {
                bool isPrime = true;
                for(int j = 2; j<= Math.Sqrt(i); j++)
                {
                    if( i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    primeNumbers.Add(i);
                }
            }
            return primeNumbers;
        }
    }
}
