using System;
using System.Diagnostics;

public class Program
{
    static void Main(string[] args)
    {
        // This project is here for you to use as a "Sandbox" to play around
        // with any code or ideas you have that do not directly apply to
        // one of your projects.

        // Console.WriteLine("Hello Sandbox World!");
        Run();
    }
    public static void Run()
    {
        var executionTime = Time(() => LotsOfLoops(100), 10);
        Console.WriteLine($"Execution Time: {executionTime} ms");
    }

    private static void LotsOfLoops(int n)
    {
        int total = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                for (int k = 0; k < n; k++)
                {
                    total += (i * j * k);
                }
            }
        }

        Console.WriteLine(total);
    }

    private static double Time(Action executeAlgorithm, int times)
    {
        var sw = Stopwatch.StartNew();
        for (var i = 0; i < times; ++i)
        {
            executeAlgorithm(); // Calls the action passed in to this method
        }

        sw.Stop();
        return sw.Elapsed.TotalMilliseconds / times;
    }
}