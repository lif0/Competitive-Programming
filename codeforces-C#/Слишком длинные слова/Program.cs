using System;

namespace Слишком_длинные_слова
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                if (input.Length <= 10) Console.WriteLine(input);
                else
                {
                    input = input.Remove(1, input.Length-2).Insert(1, input.Substring(1, input.Length - 2).Length.ToString());
                    Console.WriteLine(input);
                }
            }
        }
    }
}