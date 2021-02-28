using NUnit.Framework;
using GenericsDay15;

namespace NUnitTestProject1
{
    public class Tests
    {
        MaxNumberOfThree<int> maxNumberOfThreeInt;
        MaxNumberOfThree<double> maxNumberOfThreeDouble;
        MaxNumberOfThree<string> maxNumberOfThreeString;
        MaxNumberOfThree<int> maxNumberOfThreeParameter;
        [SetUp]
        public void Setup()
        {
            maxNumberOfThreeInt = new MaxNumberOfThree<int>();
            maxNumberOfThreeDouble = new MaxNumberOfThree<double>();
            maxNumberOfThreeString = new MaxNumberOfThree<string>();
            maxNumberOfThreeParameter = new MaxNumberOfThree<int>(new int[]{4,1,5,2,3});
        }
        /// <summary>
        /// Givens the three numbers should return maximum number.
        /// </summary>
        /// <param name="Numb1">The numb1.</param>
        /// <param name="Numb2">The numb2.</param>
        /// <param name="Numb3">The numb3.</param>
        [TestCase(10, 5, 9)]
        [TestCase(5, 10, 9)]
        [TestCase(5, 9, 10)]
        public void GivenThreeNumbersShouldReturnMaximumNumber(int Numb1, int Numb2, int Numb3)
        {
            int expected = 10;
            int actual = maxNumberOfThreeInt.MaximumOfThree(Numb1, Numb2, Numb3);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(10.5, 20.6, 30.8)]
        [TestCase(5.24, 30.8, 9)]
        [TestCase(5.44, 9.9, 30.8)]
        public void GivenThreeDoubleNumbersShouldReturnMaximumDoubleNumber(double Numb1, double Numb2, double Numb3)
        {
            double expected = 30.8;
            double actual = maxNumberOfThreeDouble.MaximumOfThree(Numb1, Numb2, Numb3);
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        /// Givens the three string should return maximum string.
        /// </summary>
        /// <param name="Numb1">The numb1.</param>
        /// <param name="Numb2">The numb2.</param>
        /// <param name="Numb3">The numb3.</param>
        [TestCase("Apple", "Orange", "Mango")]
        [TestCase("Orange", "Apple", "Mango")]
        [TestCase("Apple", "Mango", "Orange")]
        
        public void GivenThreeStringShouldReturnMaximumString(string Numb1, string Numb2, string Numb3)
        {
            string expected = "Orange";
            string actual = maxNumberOfThreeString.MaximumOfThree(Numb1, Numb2, Numb3);
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        /// Givens the random array return maximum.
        /// </summary>
        [Test]
        public void GivenRandomArrayReturnMax()
        {
            Assert.AreEqual(5,maxNumberOfThreeParameter.MaxArray());
        }
    }
}