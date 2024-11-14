using System;

namespace SebsFabrik;

public class Candy
{
    public string Flavor { get; set; }
    public int Amount { get; set; }

    public Candy(string flavor, int amount)
    {
        Flavor = flavor;
        Amount = amount;
    }
}
