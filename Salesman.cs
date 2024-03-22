public abstract class Salesman {
     private string _firstName;
    private string _lastName;

    public string FullName {
        get {
            return string.Format("{0} {1}", this._firstName, this._lastName);
        }
    }

    public Salesman(string firstName, string lastName) {
        this._firstName = firstName;
        this._lastName = lastName;
    }

    // Sell method made a concrete method 
    public void Sell() {
        this.Engage();
        this.EstablishTrust();
        this.AddressCincerns();
        this.DemoValue();
        this.Close();
    }

    protected abstract void Engage();
    protected abstract void EstablishTrust();
    protected abstract void AddressCincerns();
    protected abstract void DemoValue();
    protected abstract void Close();
    
    public virtual void SellVirtual() {
         Console.WriteLine(string.Format("Hi my name is {0}. I would recommend you to buy this item!", this.FullName));
    }
}