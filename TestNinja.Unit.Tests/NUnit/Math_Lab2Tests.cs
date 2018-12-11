using NUnit.Framework;
using System;
using TestNinja.Fundamentals;

namespace TestNinja.Unit.Tests.NUnit
{
    [TestFixture]
    public class MathLab2Tests
    {
        /// <summary>
        /// Setup
        /// </summary>
        private Math_Lab2 _mathlab2;

        [SetUp]
        public void SetUp()
        {
            _mathlab2 = new Math_Lab2();
        }

        /// <summary>
        /// Tests
        /// </summary>
        [Test]
        [TestCase(10, 0, 10)]
        [TestCase(0, 10, 10)]
        [TestCase(0, 0, 0)]

        /// <summary>
        /// Error Tests
        /// </summary>
        //[TestCase(2, 1, 1)]
        //[TestCase(1, 2, 1)]
        //[TestCase(1, 1, 2)]

        public void Max_WhenCalled_ReturnTheGreatherArgument(int a, int b, int expectedResult)
        {
            /// <summary>
            /// Act
            /// </summary>
            var result = _mathlab2.Max(a, b);

            /// <summary>
            /// Assert
            /// </summary>
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        /// <summary>
        /// Tests
        /// </summary>
        [Test]
        [TestCase(10, 20, 30)]
        [TestCase(20, 10, 30)]
        [TestCase(0, 0, 0)]

        /// <summary>
        /// Error Tests
        /// </summary>
        //[TestCase(1, 1, 3)]
        //[TestCase(1, 1, -2)]
        //[TestCase(-1, -1, 2)]
        public void Add_WhenCalled_ReturnTheGreatherArgument(int a, int b, int expectedResult)
        {
            /// <summary>
            /// Act
            /// </summary>
            var result = _mathlab2.Add(a, b);

            /// <summary>
            /// Assert
            /// </summary>
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}
