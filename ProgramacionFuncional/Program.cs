
// Una función puede guardarse en una variable, eso se llama Función de Primera Clase

var show = Show;
Some(show, "Hola como estas?");
string Show(string message)
{
   return message.ToUpper();
}


void Some(Func<string, string> fn, string message)
{
    Console.WriteLine("Hace algo al inicio");
    Console.WriteLine(fn(message));
    Console.WriteLine("Hace algo al final");
}

// --------------------------------------------------------------------------------


Console.WriteLine(Sub(2, 1));

int Sub(int a, int b)
{
    return a - b;
}

DateTime date = new DateTime(2024, 10, 1);

Console.WriteLine(GetTomorrow(date));

DateTime GetTomorrow(DateTime date)
{
    return date.AddDays(1);
}

var beer = new Beer()
{
    Name = "Guinness"
};

Console.WriteLine(ToUpper(beer).Name);
Console.WriteLine(beer.Name);


Beer ToUpper(Beer beer)
{
    var beer2 = new Beer()
    {
        Name = beer.Name.ToUpper(),
    };
    return beer2;
}

class Beer
{
    public string Name { get; set; }
}
