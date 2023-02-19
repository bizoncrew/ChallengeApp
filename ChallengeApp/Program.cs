using ChallengeApp;

var employee = new Employee("Michał", "Kowalski");
employee.AddGrade("2");
employee.AddGrade(65546977554);
employee.AddGrade(5.54655545484);
employee.AddGrade(6);
var statistics = employee.GetStatistics();
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");
Console.WriteLine($"Average: {statistics.Average:N2}");