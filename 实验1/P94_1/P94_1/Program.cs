using System;

namespace P94_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("请输入一串字符串：");
            String str;
            int number = 0;
            str = Console.ReadLine();

            for (int i = 0; i < str.Length; i++)
            {
                if ((str[i] > 64 && str[i] < 90) || (str[i] > 96 && str[i] < 123))
                {
                    number++;
                }
            }

            Console.WriteLine("字符串中英文字母的个数为：{0}个", number);
        }
    }
}
