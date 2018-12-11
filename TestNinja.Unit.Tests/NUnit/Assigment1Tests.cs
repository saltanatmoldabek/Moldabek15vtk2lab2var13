using System;
using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.Unit.Tests.NUnit
{
    [TestFixture]
    public class Assigment1Tests
    {
        /// <summary>
        /// Setup
        /// </summary>
        private Assignment1 _assignment1;

        [SetUp]
        public void SetUp()
        {
            _assignment1 = new Assignment1();
        }

        /// <summary>
        /// Tests
        /// </summary>
        [Test]
        [TestCase(30, 1,2010, "30 January. 2010")]


        /// <summary>
        /// Error Tests
        /// </summary>
        //[TestCase(31, 13, 2010, "30 January. 2010")]
        public void MyBirthday_ReturnTheGreatherArgument(int day, int mounth, int year,string expectedResult)
        {
            /// <summary>
            /// Act
            /// </summary>
            var result = _assignment1.MyBirthday(day, mounth,year);


            /// <summary>
            /// Assert
            /// </summary>
            Assert.That(result, Is.EqualTo(expectedResult).IgnoreCase);
        }
    }
}
