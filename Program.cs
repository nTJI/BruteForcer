using System;
using System.Threading;

namespace BruteForce
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            string target = "I love you!)";
            string current = "";

            for (int i = 0; i < target.Length; i++)
            {
                Console.Clear();
                string c = ((char)rand.Next(0x0020, 0x007e)).ToString();
                Console.WriteLine(current + "" + c);
                Thread.Sleep(10);

                if (c.Equals(target.Substring(i,1)))
                {
                    current += c;
                    continue;
                }

                i--;
            }
            Console.ReadLine();

        }
    }
}
