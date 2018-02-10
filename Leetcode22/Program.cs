using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace Leetcode22
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();

            Console.WriteLine("Length = {0}", new Solution().GenerateParenthesis(50).Count);
            Console.WriteLine("Pow(2, {0}) = {1}", 100, MathF.Exp(100));

            sw.Stop();

            Console.WriteLine("Time: {0}", sw.Elapsed.TotalMilliseconds);
        }

        public class Solution 
        {
            public IList<string> GenerateParenthesis(int n)
            {
                List<string> result = new List<string>();
                Backtrack(result, "", 0, 0, n);
                return result;    
            }

            public void Backtrack(List<string> result, String cur, int open, int close, int max)
            {
                if(cur.Length == max * 2)
                {
                    result.Add(cur);
                    return;
                }

                if(open < max)
                {
                    Backtrack(result, cur + "(", open + 1, close, max);
                }
                
                if(close < open)
                {
                    Backtrack(result, cur + ")", open, close + 1, max);
                }
            }
        }
    }
}
