using System;

namespace P146_2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            while (true)
            {
                myCircla c = new myCircla();
                Console.Write("半径=");
                c.R =Convert.ToDouble( Console.ReadLine());
                if (c.R == 0)
                    continue;
                Console.Write("高=");
                c.H = Convert.ToDouble(Console.ReadLine());
                if (c.H == 0)
                    continue;
                Console.WriteLine("面积={0}\n\n\n",c.getV());
               

            }
        }
    }



    class myCircla
    {

        double r, h;
        public double R
        {
            get
            {
                return r;
            }
            set
            {
                if (value > 0)
                    this.r = value;
                else
                    Console.WriteLine("半径不能为负");
            }
        }


        public double H
        {
            get
            {
                return h;
            }
            set
            {
                if (value > 0)
                    this.h = value;
                else
                    Console.WriteLine("高不能为负");
            }
        }


        public double getV()
        {
            return Math.PI * r * r * h;
        }
    }
}
