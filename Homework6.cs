using System;
using System.Collections.Generic;
using System.Text;

namespace ACC
{
    internal class Homework6
    {
        static void Pakagic(string x)
        {
            int a = 0;
            int b = 0;
            int c = 0;

            for (int i = 0; i < x.Length; i++)
            {
                if (x[i] == '(')
                {
                    a++;
                }
                else if (x[i] == ')')
                {
                    a--;
                }

                else if (x[i] == '[')
                {
                    b++;
                }
                else if (x[i] == ']')
                {
                    b--;
                }

                else if (x[i] == '{')
                {
                    c++;
                }
                else if (x[i] == '}')
                {
                    c--;
                }

                else { Console.WriteLine($"This char -> {x[i]}  is not acceptable! "); }


            }

            if (a == 0 && b == 0 && c == 0)
            {
                Console.WriteLine(true);
            }
            else { Console.WriteLine(false); }
        }

        static void Main()
        {
            Pakagic("([{)}]");
        }
    }
}
