using NUnit.Framework;
using GenericsDay15;

namespace NUnitTestProject1
{
    public class Tests
    {
        CheckMaxOfThree checkMaxOfThree;
        [SetUp]
        public void Setup()
        {
            checkMaxOfThree = new CheckMaxOfThree();
        }

        [TestCase(10, 5, 9)]
        [TestCase(5, 10, 9)]
        [TestCase(5, 9, 10)]
        public void GivenThreeNumbersShouldReturnMaximumNumber(int Numb1, int Numb2, int Numb3)
        {
            int expected = 10;
            int actual = checkMaxOfThree.MaximumOfThree(Numb1, Numb2, Numb3);
            Assert.AreEqual(expected, actual);
        }
    }
}