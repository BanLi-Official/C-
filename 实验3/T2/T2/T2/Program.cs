using System;

namespace T2
{
    class Program
    {
        static void Main(string[] args)
        {
            fushu fushu1 = new fushu(1, 2);
            fushu fushu2 = new fushu(5, -1);
            fushu fushu3 = new fushu(-1, 2);

            fushu1.print();
            fushu2.print();
            fushu3.print();

        }
    }


    class fushu
    {
        private int a, b;
        public fushu(int a,int b)
        {
            this.a = a;
            this.b = b;
            
        }

        public void print()
        {
            if(this.b<0)
                Console.WriteLine("负数为：{0}{1}i", this.a, this.b);
            else
                Console.WriteLine("负数为：{0}+{1}i",this.a,this.b);
        }
        
    }




}
