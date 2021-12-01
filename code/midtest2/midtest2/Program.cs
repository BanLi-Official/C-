using System;

namespace midtest2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Fraction fenshu=new Fraction();
            fenshu.print();
            Fraction fenshu2 = new Fraction(-155,-25);
            fenshu2 = +fenshu2;
            fenshu2.print();

            Fraction fenshu3 = new Fraction(-4, 0);
            fenshu3 = +fenshu3 ;
            fenshu3.print();

            Fraction fenshu4 = new Fraction(3, -9);
            fenshu4 = +fenshu4;
            fenshu4.print();
        }
    }


    class Fraction
    { 
     private
        int molecule;//分子
        int denominator;//分母
        bool isError = false;
        public Fraction()
        {
            molecule = 1;
            denominator = 1;
        }


        public Fraction(int a,int b)
        {
            molecule = a;
            denominator = b;
            if (b == 0)
            {
                Console.WriteLine("出现错误！分母不能为0！构造失败！");
                isError = true;
            }
        }

        public void  print()
        {
            
            if (this.denominator*this.molecule < 0)
            {
                this.molecule = -Math.Abs(this.molecule);
                
            }
            if (isError == false)
                Console.WriteLine("分数为：{0}/{1}", this.molecule, this.denominator);
            else
                Console.WriteLine("出现错误！分母不能为0！打印失败！");
        }

        public static Fraction operator +(Fraction x)
        {
            bool isfunshu = false;
            if (x.molecule *x.denominator<0) isfunshu = true;
            int min = Math.Min(Math.Abs(x.molecule), Math.Abs(x.denominator));
            x.denominator = Math.Abs(x.denominator);
            x.molecule = Math.Abs(x.molecule);
            for (int i = 2; i <= min; i++)
            {
                if (x.molecule % i == 0 && x.denominator % i == 0)
                {
                    x.molecule /= i;
                    x.denominator /= i;
                    i = 1;
                    min = Math.Min(x.molecule, x.denominator);
                   
                }
               

            }
            if (isfunshu == true) x.molecule = -x.molecule;
          
            return x;
        }

    }
}
