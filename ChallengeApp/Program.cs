using ChallengeApp;

Console.WriteLine("Witamy w programie XYZ do oceny pracowników");
Console.WriteLine("===========================================");
Console.WriteLine();

var employee = new Employee("Michał", "Kowalski");


while (true)
{
    Console.WriteLine("Podaj ocenę kolejnego pracownika: ");
    Console.WriteLine("Aby zakończyć wpisz q: ");
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
Console.WriteLine($"Average: { statistics.Average}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: { statistics.Max}");
Console.WriteLine($"Average letter: {statistics.AverageLetter}");