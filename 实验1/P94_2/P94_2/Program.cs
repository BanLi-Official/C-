using System;

namespace P94_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int index = 1;
            while (index < 101)
            {
                if (index % 3 == 0)
                {
                    Console.WriteLine("{0}可以被3整除！",index);
                }
                index++;
            }
        }
    }
}
