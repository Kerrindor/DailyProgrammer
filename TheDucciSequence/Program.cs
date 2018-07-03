using System;
using System.Collections.Generic;
using System.Linq;

namespace TheDucciSequence
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var input = Console.ReadLine();
            if (input == null) return;
            var inputTuple = input.Replace("(", string.Empty)
                .Replace(")", string.Empty)
                .Replace(" ", string.Empty)
                .Split(',');
            var tuple = inputTuple.Select(int.Parse).ToList();
            var allTuples = new List<List<int>> {tuple};
            Console.WriteLine($"[{string.Join("; ", tuple)}]");
            
            while (tuple.Sum() != 0)
            {
                
                tuple = tuple.Select((t, n) => (n != tuple.Count - 1 ? Math.Abs(t - tuple[n + 1]) : Math.Abs(t - tuple[0]))).ToList();
                if (allTuples.Any(t => t.SequenceEqual(tuple))) break;
                Console.WriteLine($"[{string.Join("; ", tuple)}]");              
                allTuples.Add(tuple);
            }
        }

    }
}