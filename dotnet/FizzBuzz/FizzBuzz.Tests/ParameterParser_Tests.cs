using System.Runtime.CompilerServices;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzz.Tests
{
    [TestClass]
    public class ParameterParser_Tests
    {

        [TestMethod]
        public void GetValue_null_input_returns_null()
        {
            Assert.AreEqual(ParameterParser.GetValue(null), null);
        }

        [TestMethod]
        public void GetValue_empty_input_returns_null()
        {
            Assert.AreEqual(ParameterParser.GetValue(new string[] {}), null);
        }

        [TestMethod]
        public void GetValue_string_input_returns_null()
        {
            Assert.AreEqual(ParameterParser.GetValue(new[] { "0fw" }), null);
        }

        [TestMethod]
        public void GetValue_valid_input_returns_value()
        {
            Assert.AreEqual(ParameterParser.GetValue(new [] { "3" }), 3);
        }
    }
}
