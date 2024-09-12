Dictionary<string, string> paisesYcapitales = new Dictionary<string, string>
{
    {"Francia", "París"},
    {"España", "Madrid"},
    {"Italia", "Roma"}
};

foreach (KeyValuePair<string, string> par in paisesYcapitales)
{
    Console.WriteLine("La capital de " + par.Key + " es " + par.Value + ".");
}

