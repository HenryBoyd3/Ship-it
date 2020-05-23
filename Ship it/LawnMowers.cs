namespace Ship_it
{
    class LawnMowers : IShippable
    {
        public decimal ShipCost { get { return 24.00m; } }

        public string Product { get { return "Lawn mower"; } }
    }
}
