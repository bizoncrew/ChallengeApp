namespace ChallengeApp.Tests
{
    internal class EmployeeTests
    {
        [Test]

        public void WhenAverageIsCorrect_ThenShowResult()
        {
            var employee = new Employee("Michał", "Kowalski");
            employee.AddGrade('D');
            employee.AddGrade(40);
            employee.AddGrade(20);
            employee.AddGrade('c');

            var statistics = employee.GetStatistics();

            Assert.AreEqual(40, statistics.Average);
        }

        public void WhenMinIsCorrect_ThenShowResult()
        {
            var employee = new Employee("Michał", "Kowalski");
            employee.AddGrade('D');
            employee.AddGrade(40);
            employee.AddGrade(20);
            employee.AddGrade('c');

            var statistics = employee.GetStatistics();

            Assert.AreNotEqual(40, statistics.Min);
        }

        public void WhenMaxIsCorrect_ThenShowResult()
        {
            var employee = new Employee("Michał", "Kowalski");
            employee.AddGrade('D');
            employee.AddGrade(40);
            employee.AddGrade(20);
            employee.AddGrade('c');

            var statistics = employee.GetStatistics();

            Assert.AreEqual(60, statistics.Max);
        }
    }
}
