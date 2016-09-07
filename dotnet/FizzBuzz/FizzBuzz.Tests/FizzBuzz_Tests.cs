using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzz.Tests
{
    [TestClass]
    public class FizzBuzz_Tests
    {
        [TestMethod]
        public void Input_of_3_returns_fizz()
        {
            Assert.AreEqual(FizzBuzz.GetResult(3), "Fizz");
        }

        [TestMethod]
        public void Input_of_5_returns_buzz()
        {
            Assert.AreEqual(FizzBuzz.GetResult(5), "Buzz");
        }

        [TestMethod]
        public void Input_of_15_returns_fizzbuzz()
        {
            Assert.AreEqual(FizzBuzz.GetResult(15), "FizzBuzz");
        }


    }
}
