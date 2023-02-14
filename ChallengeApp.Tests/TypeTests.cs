namespace ChallengeApp.Tests
{
    public class TypeTests
    {

        [Test]
        public void WhenCompareTwoDigits_ShouldGiveCorrectResult()
        {
            // arrange
            int number1 = 9;
            int number2 = 5;
            // act


            // assert
            Assert.AreNotEqual(number1, number2);

        }

        [Test]
        public void WhenPriceAreCompared_ShouldReturnResult()
        {
            // arrange
            double price1 = 21.99;
            double price2 = 21.99;
            float price3 = 22.45f;
            float price4 = 23.50f;
            // act


            // assert
            Assert.AreEqual(price1, price2);
            Assert.AreNotEqual(price3, price4);

        }

        [Test]
        public void WhenAddTwoUsers_ThemCompareIfTheyAreEqual()
        {
            // arrange
            string user1 = "Marek";
            string user2 = "Marek";
            // act


            // assert
            Assert.AreEqual(user1, user2);

        }

        [Test]
        public void GetEmployee_ShouldReturnDifferentObject()
        {
            // arrange
            var employee1 = GetEmployee("Anna", "Nowak", 25);
            var employee2 = GetEmployee("Anna", "Nowak", 25);
            // act


            // assert
            Assert.AreNotEqual(employee1, employee2);
        }

        private Employee GetEmployee(string name, string surname, int age)
        {
            return new Employee(name, surname, age);
        }
    }
}