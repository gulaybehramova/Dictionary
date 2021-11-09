using System;
using System.Collections.Generic;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Car> Cars = new Dictionary<string, Car>();
            Cars.Add("19-BF-019", new Car { Model = "Mercedes" });
            Cars.Add("10-BC-919", new Car { Model = "BMW" });
            Cars.Add("99-AF-212", new Car { Model = "Hyundai" });
            Cars.Add("77-ZZ-777", new Car { Model = "LADA" });
            foreach (var item in Cars)
            {
                Console.WriteLine($"No:{item.Key}-Model:{item.Value.Model}");
            }
            //Console.WriteLine("===============================");
            //Cars.Remove("77-zz-777");
            //foreach (var item in Cars)
            //{
            //    Console.WriteLine($"Model;{item.Value.Model}");
            //}

        }
    }
    class Car
    {
        public string Model { get; set; }
    }
}
