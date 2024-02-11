// See https://aka.ms/new-console-template for more information

using ProblemSolvingAndAlgorithms;
using System.Runtime.CompilerServices;

public class Program
{
    private static IEnumerable<string> names = new List<string> { "jack", "jill", "joe", "jessica", "joanne", "james" };
    public static void Main(string[] args)
    {
        int i = 0, j = 0;
        x: while (i < 5)
        {
            i++;
            while (j < 3)
            {
                Console.WriteLine("loop");
                goto x;
                j++;
            }
        }
        Console.ReadLine();

        //factorial(42, 61);

        //Console.ReadLine();
    }

    static void factorial(int start, int end)
    {
        int res = 0;
        for (int i = start; i <= end; i++)
        {
            res += i;
        }
        Console.WriteLine(res);
    }
}
