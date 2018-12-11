using System;
using NUnit.Framework;
using TestNinja.Fundamentals;
using static TestNinja.Fundamentals.Assignment3;

namespace TestNinja.Unit.Tests.NUnit
{
    [TestFixture]
    public class Assigment3Tests
    {
        /// <summary>
        /// Setup
        /// </summary>
        private Assignment3 _assignment3;

        [SetUp]
        public void SetUp()
        {
            _assignment3 = new Assignment3();
        }

        /// <summary>
        /// Tests
        /// </summary>
        [Test]
        [TestCase(1, true)]

        public void StartRaket_WhenCalled_ReturnStartToSpace(double energy, bool isengine)
        {
            /// <summary>
            /// Act
            /// </summary>
            var result = _assignment3.StartRaket(energy, isengine);


            /// <summary>
            /// Assert
            /// </summary>
            Assert.That(result, Is.TypeOf<StartToSpace>());
            Assert.That(result, Is.InstanceOf<StartToSpace>());
        }

        [Test]
        [TestCase(0.4, true)]
        public void StartRaket_WhenCalled_ReturnSmallEnergyError(double energy, bool isengine)
        {
            /// <summary>
            /// Act
            /// </summary>
            var result = _assignment3.StartRaket(energy, isengine);


            /// <summary>
            /// Assert
            /// </summary>
            Assert.That(result, Is.TypeOf<SmallEnergyError>());
            Assert.That(result, Is.InstanceOf<SmallEnergyError>());
        }

        [Test]
        [TestCase(0.9, false)]
        public void StartRaket_WhenCalled_ReturnEngineNotReadyError(double energy, bool isengine)
        {
            /// <summary>
            /// Act
            /// </summary>
            var result = _assignment3.StartRaket(energy, isengine);


            /// <summary>
            /// Assert
            /// </summary>
            Assert.That(result, Is.TypeOf<EngineNotReadyError>());
            Assert.That(result, Is.InstanceOf<EngineNotReadyError>());
        }
    }
}
