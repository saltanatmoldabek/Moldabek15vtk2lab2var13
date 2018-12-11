using System;
using NUnit.Framework;
using TestNinja.Fundamentals;
using static TestNinja.Fundamentals.Assignment3;

namespace TestNinja.Unit.Tests.NUnit
{
    [TestFixture]
    public class Assigment5Tests
    {
        [Test]
        [TestCase(0)]
        public void Log_InvalidError_ThrowArgumentNullException(int price)
        {
            /// <summary>
            /// Act
            /// </summary>
            var logger = new Assignment5();

            /// <summary>
            /// Assert
            /// </summary>
            Assert.That(()=>logger.BuyBilet(price), Throws.ArgumentNullException);

        }
        
    }
}
