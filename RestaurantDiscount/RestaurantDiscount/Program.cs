using System;

namespace RestaurantDiscount
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            int groupSize = int.Parse(Console.ReadLine());
            string package = Console.ReadLine();
            string hallName = "";
            double price = 0;

            if (groupSize <= 50)
            {
                hallName = "Small Hall";
                price += 2500;
            }
            else if (groupSize <= 100)
            {
                hallName = "Terrace";
                price += 5000;
            }
            else if (groupSize <= 120)
            {
                hallName = "Greathall";
                price += 7500;

            }
            

            switch (package)
            {
                case "Normal":
                    price += 500;
                    price *= 0.95;
                    break;
                case "Gold":
                    price += 750;
                    price *= 0.9;
                    break;
                case "Platinum":
                    price += 1000;
                    price *= 0.85;
                    break;
                default:
                    break;
            }
            if (groupSize<=120)
            {
                Console.WriteLine($"We can offer you the {hallName}");
                Console.WriteLine($"The price per person is {price / groupSize:f2}$");
            }
            else if (groupSize>120)
            {
                Console.WriteLine("We do not have an appropriate hall.");
            }
            
        }
    }
}
