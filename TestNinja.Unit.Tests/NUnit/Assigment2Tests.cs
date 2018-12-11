using System;
using System.Linq;
using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.Unit.Tests.NUnit
{
    [TestFixture]
    public class Assigment2Tests
    {
        /// <summary>
        /// Setup
        /// </summary>
        private Assignment2 _assignment2;

        [SetUp]
        public void SetUp()
        {
            _assignment2 = new Assignment2();
        }

        /// <summary>
        /// Tests
        /// </summary>
        [Test]

        public void GetNumbersDividedBy7_IsNumber_ReturnTheGreatherArgument()
        {
            /// <summary>
            /// Act
            /// </summary>
            var result = _assignment2.GetNumbersDividedBy7(32);


            /// <summary>
            /// Assert
            /// </summary>
            Assert.That(result, Is.Not.Empty);
            Assert.That(result.Count(), Is.EqualTo(4));
            Assert.That(result, Does.Contain(7));
            Assert.That(result, Does.Contain(14));
            Assert.That(result, Does.Contain(21));
            Assert.That(result, Does.Contain(28));
            Assert.That(result, Is.EquivalentTo(new[] { 7, 14, 21, 28 }));
        }
    }
}
