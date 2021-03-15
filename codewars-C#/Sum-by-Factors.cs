using System;
using System.Collections.Generic;
using System.Linq;
namespace ConsoleApp1
{
	public class SumOfDivided
	{
	    static List<int> primeFactors(int n)
        {
			List<int> res = new List<int>();
			n = Math.Abs(n);
			while (n % 2 == 0) {res.Add(2);n /= 2;}
			int j = 3;
			while (j * j <= n)
            {
				if (n % j == 0) { res.Add(j); n /= j; }
				else j += 2;
            }
			if (n != 1) res.Add(n);
			return res.Distinct().ToList();
		}

		public static string sumOfDivided(int[] lst)
		{
			SortedDictionary<int, int> dict = new SortedDictionary<int, int>();
            foreach (int n in lst)
            {
				foreach (int v in primeFactors(n))
                {
					if (!dict.ContainsKey(v)) dict.Add(v, n);
					else dict[v] += n;
                }
			}
			string result = String.Empty;
            foreach (var kvp in dict) result += String.Format("({0} {1})", kvp.Key, kvp.Value);
			return result;
		}
	}
}
