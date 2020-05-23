using System;

namespace Ship_it
{
    class Program
    {
        static void Main(string[] args)
        {
            int userInput;
            Console.WriteLine("Make an order using of what you would like" +
                "enter the numbers assoated with the thing you would like to accomplish." +
                "\nOnly values of 1-6 are allowed, when you want to check out press '6' to" +
                "check out and see your total.");
           
            while (true)
            {
                
                
                Console.WriteLine();
                Console.WriteLine("1. Add a Baseball Glove  to the shipment");
                Console.WriteLine("2. Add a Bicycle to the Shipment");
                Console.WriteLine("3. Add Crackers to the shipment");
                Console.WriteLine("4. Add a Lawn Mower to the shipment");
                Console.WriteLine("5. List Shipment Items");
                Console.WriteLine("6. Compute Shipping Charges");
                userInput = parseinput();
                UserOptions(userInput);
                Console.WriteLine();
                if (userInput == 6)
                    break;
            }
        }

        static void UserOptions(int number)
        {
            switch (number)
            {
                case 1:
                    Console.WriteLine(Shipper.Add(new BaseballGloves()));
                    Console.ReadKey();
                    break;
                case 2:
                    Console.WriteLine(Shipper.Add(new Bicycles()));
                    Console.ReadKey();
                    break;
                case 3:
                    Console.WriteLine(Shipper.Add(new Crackers()));
                    Console.ReadKey();
                    break;
                case 4:
                    Console.WriteLine(Shipper.Add(new LawnMowers()));
                    Console.ReadKey();
                    break;
                case 5:
                    Console.WriteLine(Shipper.ManifestList());
                    break;
                case 6:
                    Console.WriteLine(Shipper.returnCost());
                    break;
            }
        }
        static int parseinput()
        {
            int number;
            while (true)
            {
                bool success = Int32.TryParse(Console.ReadLine(), out number);
                if (success)
                {
                    Console.WriteLine();
                    return number;
                }
                else
                {
                    Console.WriteLine("error not a valid value try again");
                }
            }
        }

    }
}
