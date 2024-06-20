
var sale = new SaleWithTax(15, 1.60m);
var message = sale.GetInfo();

Console.WriteLine(message);

class SaleWithTax : Sale
{
    public decimal Tax { get; set; }
    public SaleWithTax(decimal total, decimal tax)  : base(total)
    {
        Tax = tax;
    }

    public override string GetInfo()
    {
        return "El total es " + Total + " y el impuesto es " + Tax;
    }

    public string GetInfo(int a)
    {
        return a.ToString();
    }
}

class Sale
{
    public decimal Total { get; set; }
    private decimal _some;

    public Sale(decimal total) {
        this.Total = total;
        _some = 8;
    }

    public virtual string GetInfo()
    {
        return "El total es " + Total;
    }
}