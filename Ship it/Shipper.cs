using System;
using System.Collections.Generic;

namespace Ship_it
{
    class Shipper
    {

        static List<IShippable> products = new List<IShippable>();
        public static String Add(IShippable item)
        {
            products.Add(item);
            return "1 " + item.Product + " has been added. \n " +
                "Press any to return to the menu.";

        }
        public static String ManifestList()
        {
            //is there an easier way to get a count of every item and name as part of 
            //a foreach loop without if staments?
            String name = string.Empty;
            int BaseballGloveCount = 0;
            int BicycleCount = 0;
            int CrackerCount = 0;
            int LawnMowerCount = 0;
            foreach (IShippable item in products)
            {
                if (item.Product.Contains("Baseball Glove"))
                    BaseballGloveCount++;
                if (item.Product.Contains("Bicycle"))
                    BicycleCount++;
                if (item.Product.Contains("Crackers"))
                    CrackerCount++;
                if (item.Product.Contains("Lawn mower"))
                    LawnMowerCount++;
            }
            string baseballglovePl = "Baseball Glove" + getPlural(BaseballGloveCount);
            string bicyclePl = "Bicycle" + getPlural(BicycleCount);
            string LawnmowerPl = "Lawn Mower" + getPlural(LawnMowerCount);
            //crackers is always plural so I have have it hard coded

            name = string.Format("Shipment manifest: \n {0} {1}\n {2} {3}\n {4} Crackers" +
                "\n {5} {6}", BaseballGloveCount, baseballglovePl,
                BicycleCount, bicyclePl, CrackerCount,
                LawnMowerCount, LawnmowerPl);

            return name;
        }


        public static String returnCost()
        {
            decimal cost = 0;
            foreach (IShippable item in products)
            {
                cost = cost + item.ShipCost;
            }
            return "The total shipping cost for this order is $" + cost;
        }

        private static String getPlural(int number)
        {
            if (number == 1)
                return string.Empty;
            else
                return "s";
        }
    }


}
