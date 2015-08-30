using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler17
{
    class Program
    {
        static Dictionary<int, string> numberStrings;

        static void Main(string[] args)
        {
            numberStrings = new Dictionary<int, string>()
            {
                {1, "one" },
                {2, "two" },
                {3, "three" },
                {4, "four" },
                {5, "five" },
                {6, "six" },
                {7, "seven" },
                {8, "eight" },
                {9, "nine" },
                {10, "ten" },
                {11, "eleven" },
                {12, "twelve" },
                {13, "thirteen" },
                {14, "fourteen" },
                {15, "fifteen" },
                {16, "sixteen" },
                {17, "seventeen" },
                {18, "eighteen" },
                {19, "nineteen" },
                {20, "twenty" },
                {30, "thirty" },
                {40, "forty" },
                {50, "fifty" },
                {60, "sixty" },
                {70, "seventy" },
                {80, "eighty" },
                {90, "ninety" }
            };

            int count = 0;

            foreach(int i in Enumerable.Range(1, 1000))
            {
                Console.WriteLine(getTextRepresentation(i));
                count += getValidCharCount(getTextRepresentation(i));
            }

            Console.WriteLine(count);
            Console.ReadLine();
        }

        private static int getValidCharCount(string s)
        {
            return s.Replace(" ", String.Empty).Replace("-", String.Empty).Length;
        }

        private static string getTextRepresentation(int i)
        {
            string rep = "";

            if (i < 0 || i > 1000)
                throw new ArgumentOutOfRangeException();

            if (i == 1000)
                return "one thousand";

            if (i > 99) {
                rep += numberStrings[i / 100] + " hundred";
                i = i % 100;
                if (i == 0)
                    return rep;
                else
                    rep += " and ";
            }

            if (i >= 20)
            {
                rep += numberStrings[i - (i % 10)];
                i = i % 10;
                if (i == 0)
                    return rep;
                else
                    return rep + "-" + numberStrings[i];
            }

            return rep + numberStrings[i];
        }
    }
}
