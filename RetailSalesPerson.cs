using System;
public class RetailSalesPerson : Salesman
{
    public RetailSalesPerson(string firstName, string lastName) : base(firstName, lastName)
    {
    }

    public override void Sell()
    {
        Console.WriteLine(string.Format("Hi my name is {0}. I would recommend you to buy this pen!", this.FullName));
    }

    public void Develop() {
        Console.WriteLine("I develop myself by watching retail sales training videos.");
    }
}