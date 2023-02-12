using ChallengeApp;

Employee user1 = new Employee("Marek ", "Kowalski ", 35);
Employee user2 = new Employee("Anna ", "Nowak ", 25);
Employee user3 = new Employee("Bill ", "Clinton ", 65);

user1.AddScore(5);
user1.AddScore(5);
user1.AddScore(5);
user1.AddScore(5);
user1.AddScore(5);

user2.AddScore(5);
user2.AddScore(4);
user2.AddScore(2);
user2.AddScore(1);
user2.AddScore(2);

user3.AddScore(5);
user3.AddScore(1);
user3.AddScore(1);
user3.AddScore(3);
user3.AddScore(3);

List<Employee> employees = new List<Employee>()
{
    user1, user2, user3
};

var maxResult = -1;
Employee userWithMaxResult = null;

foreach(var employee in employees)
{
    if (employee.Result > maxResult)
    {
        maxResult = employee.Result;
        userWithMaxResult = employee;
    }
}
Console.WriteLine("Pracownik z największą ilością punktów - " + userWithMaxResult.Result + " - to " + userWithMaxResult.Name + userWithMaxResult.Surname + " lat " + userWithMaxResult.Age);