using System;

namespace T1
{
    class Program
    {
        static void Main(string[] args)
        {
            truck Truck = new truck();
            Console.WriteLine("以下是卡车对象调用的方法");
            Truck.vehicleRun();
            Truck.truckRun();

            smallTruck smallTruck = new smallTruck();
            Console.WriteLine("以下是微型卡车对象调用的方法");
            smallTruck.vehicleRun();
            smallTruck.truckRun();
            smallTruck.smallTruckRun();
        }

        class vehicle 
        {
            public void vehicleRun()
            {
                Console.WriteLine("汽车正在跑");
            }
        
        }


        class truck :vehicle
        {
            public void truckRun()
            {
                Console.WriteLine("卡车正在跑");
            }

        }

        class smallTruck : truck
        {
            public void smallTruckRun()
            {
                Console.WriteLine("微型卡车正在跑");
            }
        
        }
    }
}
