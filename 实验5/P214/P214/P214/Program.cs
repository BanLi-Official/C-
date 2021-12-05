using System;

namespace P214
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] a = new int[4, 4]{
                    { 1,2,3,4 },
                    { 5,6,7,8 },
                    { 9,10,11,12 },
                    { 13,14,15,16 }
            };

            Console.WriteLine("原始矩阵：");
            for (int x = 0; x < 4; x++)
            {
                for (int y = 0; y < 4; y++)
                {
                    Console.Write(string.Format("{0,10}",a[x,y].ToString()));
                }
                Console.WriteLine("");
            }


            
            Console.WriteLine("上三角矩阵：");
            for (int x = 0; x < 4; x++)
            {
                for (int y = 0; y < 4; y++)
                {
                    if (x> y) 
                    Console.Write("          ");
                    else
                    Console.Write(string.Format("{0,10}", a[x, y].ToString()));
                }
                Console.WriteLine("");
            }



            Console.WriteLine("下三角矩阵：");
            for (int x = 0; x < 4; x++)
            {
                for (int y = 0; y < 4; y++)
                {
                    if (x < y)
                        Console.Write("          ");
                    else
                        Console.Write(string.Format("{0,10}", a[x, y].ToString()));
                }
                Console.WriteLine("");
            }


            Console.WriteLine("两对角线之和：");
            int sum = 0;
            for (int x = 0; x < 4; x++)
            {
                for (int y = 0; y < 4; y++)
                {
                    if (x == y||x+y==3)
                        sum += a[x, y];
                    
                }

            }
            Console.WriteLine(sum);


            Console.WriteLine("转置矩阵矩阵：");
            int temp = 0;
            for (int x = 0; x < 4; x++)
            {
                for (int y = 0; y < 4; y++)
                {
                    if (x < y)
                    {
                         temp= a[x, y] ;
                        a[x, y] = a[y, x];
                        a[y, x] = temp;

                    }

                }
              
            }
            
            for (int x = 0; x < 4; x++)
            {
                for (int y = 0; y < 4; y++)
                {
                    Console.Write(string.Format("{0,10}", a[x, y].ToString()));
                }
                Console.WriteLine("");
            }



        }
    }
}
