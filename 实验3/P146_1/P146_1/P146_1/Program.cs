using System;

namespace P146_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入产品名称：奔驰，宝马，克迪拉克");
            string str = Console.ReadLine();
            car b = new car("奔驰", "x5", "black");
            car m = new car("宝马", "xt5", "red");
            car k = new car("凯迪拉克", "CT-4", "blue");
            if (str.Equals(b.name))
            {
                b.print_messages();
            }
            if (str.Equals(m.name))
            {
                m.print_messages();
            }
            if (str.Equals(k.name))
            {
                k.print_messages();
            }
        }
    }


    class car
    {
        public string name, type, color;
        public car(string a1, string a2, string a3)
        {
            name =a1;
            type = a2;
            color = a3;
           
        }

        public void print_messages()
        {
            Console.WriteLine("轿车的品牌：{0}", name);
            Console.WriteLine("轿车的型号：{0}", type);
            Console.WriteLine("轿车的颜色：{0}", color);
        }
    }
}
