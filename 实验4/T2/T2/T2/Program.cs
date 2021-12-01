using System;

namespace T2
{
    class Program
    {
        static void Main(string[] args)
        {
            Shixi shixi = new Shixi("赵峰",5500,"2");
            Programmer programer = new Programmer("张强",45000,2);
            Manager manager = new Manager("约翰",1000000,"玛丽");

            shixi.Print();
            Console.WriteLine("\n");
            programer.Print();
            programer.Promote();
            Console.WriteLine("\n");
            manager.Print();
            (manager as IPromotable).Promote();
            (manager as IGoodWork).Promote();
            
        }
    }


    abstract class Employee
    {

        public string name;
        public double salary;

      
        abstract public void Print();
    }

    public interface IPromotable
    {
        public void Promote();
    }


    public interface IGoodWork
    {
        public void Promote();
    }


    class Shixi : Employee
    {
        string months;

        public Shixi(string str1, double str2, string str3)
        {
            name = str1;
            salary = str2;
            months = str3;
        }
        public override void Print()
        {
            Console.WriteLine("姓名：{0}", name);
            Console.WriteLine("薪水：{0}", salary);
            Console.WriteLine("实习期：{0}", months);
            
        }
    }


    class Programmer : Employee, IPromotable
    {
        double hours;


        public Programmer(string str1, double str2, double str3)
        {
            name = str1;
            salary = str2;
            hours = str3;
        }
        public override void Print()
        {
            Console.WriteLine("姓名：{0}", name);
            Console.WriteLine("薪水：{0}", salary);
            Console.WriteLine("加班时间：{0}", hours);
        }
        public void Promote()
        {
            salary = salary * 1.5;
            Console.WriteLine("程序员职位晋升！加薪后的薪水：{0}", salary);
        }
    }




    class Manager : Employee, IPromotable,IGoodWork
    {
        string mishu;

        public Manager(string str1, double str2, string str3)
        {
            name = str1;
            salary = str2;
            mishu = str3;
        }

        public override void Print()
        {
            Console.WriteLine("姓名：{0}", name);
            Console.WriteLine("薪水：{0}", salary);
            Console.WriteLine("秘书：{0}", mishu);
            

        }
          void IPromotable.Promote()
        {
            salary = salary * 1.8;
           

        }

        void IGoodWork.Promote()
        {
            
            Console.WriteLine("经理职位晋升！加薪后的薪水：{0}", salary);

        }


    }
}
