using System;

namespace Арбуз
{
    class Program
    {
        static void Main(string[] args)
        {
            int w = int.Parse(Console.ReadLine());
            
            if (w != 2 && w % 2 == 0) Console.WriteLine("YES");
            else Console.WriteLine("NO");   
        }
    }
}