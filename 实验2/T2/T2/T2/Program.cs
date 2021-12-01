using System;

namespace T2
{
    class Program
    {
        static void Main(string[] args)
        {
            Double d_a, d_b, d_c;
            Console.WriteLine("请输入三角形三边长：");
            Console.Write("a=");
            d_a = Convert.ToDouble( Console.ReadLine());
            Console.Write("b=");
            d_b = Convert.ToDouble(Console.ReadLine());
            Console.Write("c=");
            d_c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("三角形面积：{0}", Surface(d_a, d_b, d_c));

            Double r_a, r_b;
            Console.WriteLine("请输入矩形边长：");
            Console.Write("a=");
            r_a = Convert.ToDouble(Console.ReadLine());
            Console.Write("b=");
            r_b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("矩形面积：{0}", Surface(r_a, r_b));

            Double c_a;
            Console.WriteLine("请输入圆的半径：");
            Console.Write("a=");
            c_a = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("圆面积：{0}", Surface(c_a));

        }

        protected  static double  Surface()
        {
            return 1.0;
        }
        

        public static double Surface(double a, double b, double c)
        {
            double S;
            S=(1.0/4.0)*Math.Sqrt((a + b + c)*(a + b - c) * (a + c - b) * (b + c - a));
            return S;
        }

        public static double Surface(double a, double b )
        {
            return a * b;
        }

        public static double Surface(double a)
        {
            return Math.PI * a * a;
        }
    }
}
