namespace Ship_it
{
    class Bicycles : IShippable
    {
        public decimal ShipCost { get { return 20.50m; } }

        public string Product { get { return "Bicycle"; } }
    }
}
