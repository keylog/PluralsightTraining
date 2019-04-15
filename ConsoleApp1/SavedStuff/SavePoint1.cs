using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class SavePoint1
    {
        public void SavePoint_3_31_19()
        {
            string test = "Reverse this string";

            Console.WriteLine(string.Join(" ", test.Split(' ').Reverse().ToArray()));

            string test2 = "Now reverse this string";

            StringBuilder sb = new StringBuilder();

            string[] split = test2.Split(' ');

            for (int i = split.Length - 1; i >= 0; i--)
            {
                sb.Append(split[i]);
                sb.Append(" ");
            }

            Console.WriteLine(sb);

            string test3 = "This is test three";

            Console.WriteLine(String.Join(" ", test3.Split(' ').Reverse().ToArray()));

            string test4 = "This is test four";

            Console.WriteLine(String.Join(" ", test4.Split(' ').Reverse()));

            Console.ReadKey();

        }
    }
}
