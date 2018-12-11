using NUnit.Framework;
using System;
using TestNinja.Fundamentals;

namespace TestNinja.Unit.Tests.NUnit
{
    [TestFixture]
    public class MathLab1TestsNew
    {
        //Var 13
        /// Setup
        private Math_Lab1 _mathlab1;

        [SetUp]
        public void SetUp()
        {
            _mathlab1 = new Math_Lab1();
        }

        /// Tests
        [Test]
        [TestCase(true, true, true)]
        [TestCase(false, false, false)]
        [TestCase(false, true, false)]
        [TestCase(true, false, false)]

        /// Error Tests
        //[TestCase(true, true, false)]
        //[TestCase(false, false, true)]
        //[TestCase(false, true, true)]
        //[TestCase(true, false, true)]

        public void Logical_IsArgumetsAandB_ReturnTheGreatherArgument(bool a, bool b, bool expectedResult)
        {
            /// <summary>
            /// Act
            /// </summary>
            var result = _mathlab1.LogicalAND(a, b);


            /// <summary>
            /// Assert
            /// </summary>
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}
