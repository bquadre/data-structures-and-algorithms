using System;

namespace data_structures_and_algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var result = Algorithms.simpleArraySum(new int[] {9,8,7,7,8, 90});
            Console.WriteLine("Simple array sum = " + result);
        }
    }
}
