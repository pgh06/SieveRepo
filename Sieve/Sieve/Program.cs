using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sieve
{
    class Program
    {
        static void Main(string[] args)
        {
            long upperBound = 121;
            bool[] content = new bool[upperBound];

            for (int i = 2; i < upperBound; i++)
            {
                content[i] = true;
            }

            for (int k = 2; k < upperBound; k++)
            {
                if (content[k])
                {
                    for (int i = 2; (i * k) < upperBound; i++)
                    {
                        content[i * k] = false;
                    }
                }
            }

            for (int i = 2; i < content.Length; i++)
            {
                Console.WriteLine(i + " IsPrime: " + content[i]);
            }

            Console.ReadLine();
        }
    }
}
