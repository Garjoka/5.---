using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.Write("Enter the number of vectors: ");
        int N = int.Parse(Console.ReadLine());
        List<double[]> vectors = new List<double[]>();

        for (int i = 0; i < N; i++)
        {
            Console.Write($"Enter vector {i + 1} separated by space: ");
            double[] vector = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            vectors.Add(vector);
        }

        double minLength = vectors.Min(vector => Math.Sqrt(vector.Sum(x => x * x)));
        Console.WriteLine($"Shortest vector length: {minLength}");
    }
}
