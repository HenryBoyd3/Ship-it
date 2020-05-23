namespace Ship_it
{
    class BaseballGloves : IShippable
    {
        public decimal ShipCost { get { return 3.23m; } }

        public string Product { get { return "Baseball Glove"; } }
    }
}
