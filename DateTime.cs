/*

using System.Globalization;

DateTime data = DateTime.Now;
Console.WriteLine(data.ToString("dd/mm/yyyy hh:mm"));
Console.WriteLine(data.ToString("dd-mm-yyyy HH:MM"));

string dataString = "2022-04-17 18:00";

bool sucesso = DateTime.TryParseExact(dataString, 
    "yyyy-mm-dd HH:mm", 
    CultureInfo.InvariantCulture, 
    DateTimeStyles.None, out DateTime data);
Console.WriteLine(data);

if (sucesso)
{
    Console.WriteLine($"Conversão com sucesso! Data: {data}");
}
else 
{
    Console.WriteLine($"{dataString} não é uma data válida");
}

Console.WriteLine(data.ToString("dd/mm/yyyy hh:mm"));
Console.WriteLine(data.ToString("dd-mm-yyyy HH:MM"));

Console.WriteLine(data);
Console.WriteLine(data.ToShortDateString());
Console.WriteLine(data.ToShortTimeString());

*/