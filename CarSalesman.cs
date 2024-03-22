using System;

public class CarSalesman : Salesman
{
    public CarSalesman(string firstName, string lastName) : base(firstName, lastName)
    {
    }

    // public override void Sell()
    // {
    //     // Console.WriteLine(string.Format("Hi my name is {0}. I would recommend you to buy this car!", this.FullName));
    // }

    protected override void Engage()
    {
        Console.WriteLine("Hello");
    }

    protected override void EstablishTrust()
    {
        Console.WriteLine("I just want quickly help you.");
    }

    protected override void AddressCincerns()
    {
        Console.WriteLine("Everything is 10% discounted!");
    }

    protected override void DemoValue()
    {
        Console.WriteLine("Our customers love it");
    }

    protected override void Close()
    {
        Console.WriteLine("Buy this car");
    }
}