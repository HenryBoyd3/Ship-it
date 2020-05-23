namespace Ship_it
{
    interface IShippable
    {
        decimal ShipCost { get; }
        string Product { get; }
    }
}
