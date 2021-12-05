using System;

namespace P244
{
    class Program
    {
        static void Main(string[] args)
        {
            DayCollection a = new DayCollection();
            a[1] = "周一";
            a[2] = "周二";
            a[3] = "周三";
            a[4] = "周四";
            a[5] = "周五";
            a[6] = "周六";
            a[0] = "周日";

            int need;
            while (true)
            {
                
                Console.WriteLine("输入一个数字(11退出)：");
                need = Convert.ToInt32(Console.ReadLine());
                if (need == 11)
                {
                    break;
                }
                Console.WriteLine(a[need]);

            }



        }
    }




    public class DayCollection
    {
        private string[] name = new string[7];

        public string this[int Index]
        {
            get
            {
                if (Index < 7 && Index > -1)
                    return name[Index];
                else
                    return "-1";
            }
            set
            {
                name[Index] = value;
            }
        }
    }
}
