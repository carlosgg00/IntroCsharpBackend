var names = new List<string>()
{
    "Hector", "Francisco", "Ana", "Hugo", "Pedro"
};

var namesResult = from n in names
                  where n.Length > 3 && n.Length < 5
                  orderby n descending
                  select n;

var namesResult2 = names.Where(n => n.Length > 3 && n.Length < 5)
                        .OrderByDescending(n => n)
                        .Select(d => d);

foreach (var name in namesResult2)
{
    Console.WriteLine(name);
}