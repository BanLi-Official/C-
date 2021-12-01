using System;

namespace T3
{
    class Program
    {
        static void Main(string[] args)
        {
            xiangliang a = new xiangliang(1, 2, 3);
            xiangliang b = new xiangliang(3, 2, 1);
            xiangliang c = a + b;
            Console.WriteLine("向量a+向量b=({0},{1},{2})", c.x, c.y, c.z);
        }


       
    }

    class xiangliang
    {
        public  int x, y, z;
        public xiangliang(int x,int y,int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        public static xiangliang operator + (xiangliang a, xiangliang b)
        {
            return new xiangliang(a.x + b.x, a.y + b.y, a.z + b.z);
  
        }
    }
}
