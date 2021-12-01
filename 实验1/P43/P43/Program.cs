using System;


namespace P43
{
    class Program
    {
        static void Main(string[] args)
        {
            double money;
            int month;
            double rate_year, rate_month;
            double pay;


            Console.Write("贷款金额");
            money= double.Parse(Console.ReadLine());
            Console.Write("还款月数");
            month = int.Parse(Console.ReadLine());
            Console.Write("贷款利率");
            rate_year = double.Parse(Console.ReadLine());

            rate_month = rate_year / 12;
            pay = money * rate_month * Math.Pow((1 + rate_month), month) / (Math.Pow((1 + rate_month), month) - 1);


           
            Console.WriteLine("每个月需还款{0}元", pay);

        }
    }
}
