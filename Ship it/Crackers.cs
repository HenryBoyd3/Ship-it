namespace Ship_it
{
    class Crackers : IShippable
    {
        public decimal ShipCost
        {
            get { return 0.57m; }
        }

        public string Product
        {
            get { return "Crackers"; }
        }
    }
}
