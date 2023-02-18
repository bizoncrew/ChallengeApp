using ChallengeApp;

var employee = new Employee("Michał", "Kowalski");
employee.AddGrade(2);
employee.AddGrade(3);
employee.AddGrade(5);
var statistics = employee.GetStatistics();
Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");