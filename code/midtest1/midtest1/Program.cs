using System;

namespace midtest1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            long number;
            Console.Write("请输入一个100000以内的值：");
            number =Convert.ToInt32( Console.ReadLine());

            long mul=1;
            for (int index = 1; index <= number; index++)
            {
                mul = mul * index;
                mul = mul % 1000;
                
            }
            Console.WriteLine("{0}的阶乘结果后三位为：{1}", number,String.Format("{0:D3}", mul));


            /*
            Console.Write("请输入一个整数：");
            long n = long.Parse(Console.ReadLine());
            long i = 1;
            long result = 1;
            while (i <= n)
            {
                result = ((result % 1000) * (i % 1000)) % 1000;
                i++;
            }
            Console.WriteLine("{0}!={1}", n, String.Format("{0:D3}", result));
            Console.ReadLine();*/

        }
    }
}
