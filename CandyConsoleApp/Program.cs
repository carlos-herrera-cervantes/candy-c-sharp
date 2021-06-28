using System;
using CandyDomain.Models;

namespace CandyConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var ratings = new[] { 1, 0, 2 };
            int result = SuperArray.GetNumberOfCandies(ratings);
            Console.WriteLine($"The max number neccessary to accomplish the candies is: {result}");
        }
    }
}
