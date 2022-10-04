using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FindBob
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = FindBobCountByRegex();
            Console.WriteLine($"result of {nameof(FindBobCountByRegex)}:{count}");

            count = FindBobCountByLoop();
            Console.WriteLine($"result of {nameof(FindBobCountByLoop)}:{count}");
            Console.ReadKey();
        }


        /// <summary>
        /// Find Count of 'bob' in string by using Regex
        /// </summary>
        public static int FindBobCountByRegex()
        {
            string testStr = "hi! bob is my friend.bob is a programmer";
            int count = Regex.Matches(testStr, "bob").Count;
            return count;
        }

        /// <summary>
        /// Find Count of 'bob' in string by using Loop
        /// </summary>
        public static int FindBobCountByLoop()
        {
            string testStr = "hi! bob is my friend.bob is a programmer";
            int count = 0;
            for (int i = 0; i < testStr.Length; i++)
            {
                if (testStr[i] == 'b' && testStr[i + 1] == 'o' && testStr[i + 2] == 'b')
                    count += 1;
            }
            return count;
        }
    }
}
