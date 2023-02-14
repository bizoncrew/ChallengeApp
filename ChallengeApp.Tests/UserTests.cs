namespace ChallengeApp.Tests
{
    public class Tests
    {

        [Test]
        public void WhenTwoNumbersAreAdded_ShouldReturnSum()
        {
            // arrange
            var user1 = new Employee("Marek", "Kowalski", 33);
            user1.AddScore(55);
            user1.AddScore(7);
            user1.AddScore(8);
            // act
            var result = user1.Result;

            // assert
            Assert.AreEqual(70, result);

        }

        [Test]
        public void WhenNegativePointsAreAdded_ShouldReturnSum()
        {
            // arrange
            var user2 = new Employee("Marek", "Kowalski", 33);
            user2.NegativeScore1(5);
            user2.AddScore(17);
            user2.AddScore(8);
            // act
            var result = user2.Result;

            // assert
            Assert.AreEqual(20, result);

        }
    }
}