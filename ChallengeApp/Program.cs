using ChallengeApp;

Console.WriteLine("Witamy w programie XYZ do oceny pracowników");
Console.WriteLine("===========================================\n");

var employee = new Employee("name", "surname");

Console.WriteLine("Podaj imię pracownika : ");
Console.ReadLine();
Console.WriteLine("Podaj nazwisko pracownika : ");
Console.ReadLine();

 while (true)
{
    Console.WriteLine($"Wpisz ocenę pracownika z zakresu od 0 do 100 i potwierdź {"Enter"}.\nAby przejść do następnej osoby wpisz q : ");
    var input = Console.ReadLine();
    if (input == "q")
    {
        break;
    }  

    try
    {
        employee.AddGrade(input);
    }
    catch(Exception e) 
    {
        Console.WriteLine($"Exception catched: {e.Message}");
    }
}

var statistics = employee.GetStatistics();

Console.WriteLine($"Average: {statistics.Average}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");
Console.WriteLine($"Average letter: {statistics.AverageLetter}");

var supervisor = new Supervisor("name", "surname");

Console.WriteLine("\nPodaj imię kierownika : ");
Console.ReadLine();
Console.WriteLine("Podaj nazwisko kierownika : ");
Console.ReadLine();

while (true)
{
    Console.WriteLine("Podaj  ocenę kierownika z zakresu od 1 do 100 lub w systemie ocen szkolnych od 1 do 6.\nAby zakończyć wpisz q : ");
    var input = Console.ReadLine();
    if (input == "q")
    {
        break;
    }

    try
    {
        supervisor.AddGrade(input);
    }
    catch (Exception e)
    {
        Console.WriteLine($"Exception catched: {e.Message}");
    }
}

var statistics1 = supervisor.GetStatistics();
Console.WriteLine($"Average: { statistics1.Average}");
Console.WriteLine($"Min: {statistics1.Min}");
Console.WriteLine($"Max: { statistics1.Max}");
Console.WriteLine($"Average letter: {statistics1.AverageLetter}");