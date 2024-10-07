using Sprintverseny;
using System.Text;
List<Sprint> Sportolo = [];


using StreamReader sr = new(path: "forras.txt", encoding: Encoding.UTF8);

while (!sr.EndOfStream) Sportolo.Add(new(sr.ReadLine()));

Console.WriteLine($"{Sportolo.Count()} db versenyző fejezte be a versenyt!");

var linq1 = Sportolo.Count(s => s.Kateg == "elit");
Console.WriteLine($"Versenyzők száma az elit kategóriában: {linq1}");

var linq2 = Sportolo.Where(s => s.Sex == "n").Average(s => s.Age);
Console.WriteLine($"Női versenyzők átlag életkora: {linq2:00}");

var linq3 = Sportolo.Sum(s => s.times["BikeTime"].TotalHours);
Console.WriteLine($"A versenyzők kerékpározással töltött ideje: {linq3:0.00} óra");

var linq4 = Sportolo.FindAll(s => s.Kateg == "elit junior").Average(s => s.times["SwimTime"].TotalMinutes);
Console.WriteLine($"Átlagos úszás idő, elit junior kategóriában: {linq4:0.00} perc");

//var linq5


var linq6 = Sportolo.GroupBy(s => s.Kateg);
Console.WriteLine("kategória szerint csoportosítva a versenyt befejezők száma: ");
foreach (var group in linq6.OrderBy(g => g.Key))
{
    Console.WriteLine($"\t{group.Key} ({group.Count()} db)");
}

//linq++