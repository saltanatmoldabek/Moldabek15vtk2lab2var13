using System;
using NUnit.Framework;
using TestNinja.Fundamentals;
using static TestNinja.Fundamentals.Assignment3;

namespace TestNinja.Unit.Tests.NUnit
{
    [TestFixture]
    public class Assigment4Tests
    {
        [Test]
        public void GetPricePrivilege_IsPrice_ReturnIsEquaTrue()
        {
            /// <summary>
            /// Act
            /// </summary>
            var logger = new Assignment4();
            logger.BuyBilet(2000);

            /// <summary>
            /// Assert
            /// </summary>
            Assert.That(logger.PricePrivilege, Is.EqualTo(true));

        }
        
    }
}
