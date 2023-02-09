using ChallengeApp;

Employee user1 = new Employee("Marek", "Kowalski", 33);
Employee user2 = new Employee("Anna", "Nowak", 25);
Employee user3 = new Employee("Bill", "Clinton", 65);

user1.AddScore(5);
user1.AddScore(2);
user1.AddScore(1);
user1.AddScore(1);
user1.AddScore(3);

user2.AddScore(4);
user2.AddScore(10);
user2.AddScore(2);
user2.AddScore(7);
user2.AddScore(1);

user3.AddScore(9);
user3.AddScore(6);
user3.AddScore(3);
user3.AddScore(1);
user3.AddScore(5);

List<Employee> users = new List<Employee>()
{
    user1, user2, user3
};

int maxResult = -1;
Employee userWithMaxResult = null;
foreach (var user in users)
{
    if (user.Result > maxResult)
    {
        userWithMaxResult = user;
    }
}
Console.WriteLine("Najwyższy wynik to - " + userWithMaxResult.Result + " , a osiągnął go " + userWithMaxResult.Name +" "+ userWithMaxResult.Surname + " lat " + userWithMaxResult.Age);
Console.WriteLine("Congratulations Bill!");