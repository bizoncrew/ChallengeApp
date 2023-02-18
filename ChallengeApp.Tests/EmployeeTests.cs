namespace ChallengeApp.Tests
{
    internal class EmployeeTests
    {
        [Test]

        public void WhenMinValueIsCorrect_ThenShowResult()
        {
            var employee = new Employee("Michał", "Kowalski");
            employee.AddGrade(2);
            employee.AddGrade(3);
            employee.AddGrade(5);

            var statistics = employee.GetStatistics();

            Assert.AreEqual(2, statistics.Min);
        }

        [Test]

        public void WhenMaxValueIsCorrect_ThenShowResult()
        { 
            var employee = new Employee("Michał", "Kowalski");
            employee.AddGrade(2);
            employee.AddGrade(3);
            employee.AddGrade(5);

            var statistics = employee.GetStatistics();

            Assert.AreEqual(5, statistics.Max);
        }
        [Test]

        public void WhenAverageIsCorrect_ThenShowResult()
        {
            var employee = new Employee("Michał", "Kowalski");
            employee.AddGrade(2);
            employee.AddGrade(3);
            employee.AddGrade(5);

            var statistics = employee.GetStatistics();

            Assert.LessOrEqual(3.33, statistics.Average);
        }
    }
}
