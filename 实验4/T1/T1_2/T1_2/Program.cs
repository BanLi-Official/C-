using System;

namespace T1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            vehicle Vehicle = new vehicle();
            vehicle truck = new truck();
            vehicle samllTruck = new smallTruck();

            Vehicle.vehicleRun();
            truck.vehicleRun();
            samllTruck.vehicleRun();
        }
    }


    class vehicle
    {
        virtual public void vehicleRun()
        {
            Console.WriteLine("汽车在跑");
        }
        
    }

    class truck : vehicle
    {
        public override void vehicleRun()
        {
            Console.WriteLine("卡车正在跑");
        }
    }


    class smallTruck : vehicle
    {
        public override void vehicleRun()
        {
            Console.WriteLine("微型卡车正在跑");
        }
    }
}
