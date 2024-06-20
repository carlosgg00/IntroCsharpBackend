using System.Text.Json;

var carlos = new People()
{
    Name = "Carlos",
    Age = 23
};

People.Get();

string json = JsonSerializer.Serialize(carlos);

Console.WriteLine(json);

string myJson = @"{
    ""Name"":""Juan"",
    ""Age"":23
    
}";

People? juan = JsonSerializer.Deserialize<People>(myJson);
Console.WriteLine(juan?.Name);
Console.WriteLine(juan?.Age);
public class People
{
    public string Name { get; set; }
    public int Age { get; set; }
    public static string Get() => "Hola";
}

