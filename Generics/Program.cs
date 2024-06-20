var numbers = new MyList<int>(5);
var names = new MyList<string>(5);
var beers = new MyList<Beer>(5);


numbers.Add(1);
numbers.Add(2);
numbers.Add(3);
numbers.Add(4);
numbers.Add(5);
numbers.Add(6);

names.Add("one");
names.Add("two");
names.Add("three");
names.Add("four");
names.Add("five");
names.Add("six");

beers.Add(new Beer()
{
    Name = "Salva Vida",
    Price = 5
});

beers.Add(new Beer()
{
    Name = "Barena",
    Price = 8
});

beers.Add(new Beer()
{
    Name = "Port Royal",
    Price = 6
});

beers.Add(new Beer()
{
    Name = "Toña",
    Price = 4
});

beers.Add(new Beer()
{
    Name = "Ultra",
    Price = 8
});

beers.Add(new Beer()
{
    Name = "Heineken",
    Price = 8
});



Console.WriteLine(numbers.GetContent());
Console.WriteLine(names.GetContent());
Console.WriteLine(beers.GetContent());


public class MyList<T>
{
    private List<T> _list;
    private int _limit;

    public MyList(int limit) { 
        _limit = limit;
        _list = new List<T>();
    }

    public void Add(T element)
    {
        if (_list.Count < _limit) 
        {
            _list.Add(element);
        }
    }

    public string GetContent()
    {
        string content = "";
        foreach (var element in _list) 
        {
            content += element+", ";
        }
        return content;
    }
}

public class Beer
{
    public string Name { get; set; }
    public decimal Price { get; set; }

    public override string ToString()
    {
        return "Nombre: "+Name+" Precio: " +Price;
    }
}