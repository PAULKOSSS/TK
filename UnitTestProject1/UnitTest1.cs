using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TK;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        private MainWindow _window;

        [TestInitialize]
        public void Setup()
        {
            _window = new MainWindow();
        }

        [TestMethod]
        public void Max_PositiveNumbers_ReturnsMax()
        {
            double result = _window.Max(5.0, 2.0, 8.0);
            Assert.AreEqual(8.0, result);
        }

        [TestMethod]
        public void Max_NegativeNumbers_ReturnsMax()
        {
            double result = _window.Max(-3.5, -10.0, -1.2);
            Assert.AreEqual(-1.2, result);
        }

        [TestMethod]
        public void Max_MixedNumbers_ReturnsMax()
        {
            double result = _window.Max(-5.0, 0.0, 3.3);
            Assert.AreEqual(3.3, result);
        }

        [TestMethod]
        public void Max_AllEqual_ReturnsThatNumber()
        {
            double result = _window.Max(7.7, 7.7, 7.7);
            Assert.AreEqual(7.7, result);
        }

        [TestMethod]
        public void Max_WithDoubleMaxValue_ReturnsMax()
        {
            double result = _window.Max(double.MaxValue, 1e307, 0);
            Assert.AreEqual(double.MaxValue, result);
        }

        [TestMethod]
        public void Max_WithDoubleMinValue_ReturnsLarger()
        {
            double result = _window.Max(double.MinValue, -1e307, 0);
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void Max_WithZeroAndPositive_ReturnsPositive()
        {
            double result = _window.Max(0.0, 0.0, 5.0);
            Assert.AreEqual(5.0, result);
        }

        [TestMethod]
        public void Max_WithPrecision_ReturnsCorrect()
        {
            double result = _window.Max(0.1, 0.2, 0.30000000000000004);
            Assert.AreEqual(0.30000000000000004, result);
        }

        [TestMethod]
        public void Min_PositiveNumbers_ReturnsMin()
        {
            double result = _window.Min(5.0, 2.0, 8.0);
            Assert.AreEqual(2.0, result);
        }

        [TestMethod]
        public void Min_NegativeNumbers_ReturnsMin()
        {
            double result = _window.Min(-3.5, -10.0, -1.2);
            Assert.AreEqual(-10.0, result);
        }

        [TestMethod]
        public void Min_MixedNumbers_ReturnsMin()
        {
            double result = _window.Min(-5.0, 0.0, 3.3);
            Assert.AreEqual(-5.0, result);
        }

        [TestMethod]
        public void Min_AllEqual_ReturnsThatNumber()
        {
            double result = _window.Min(7.7, 7.7, 7.7);
            Assert.AreEqual(7.7, result);
        }

        [TestMethod]
        public void Min_WithDoubleMinValue_ReturnsMin()
        {
            double result = _window.Min(double.MinValue, -1e307, 0);
            Assert.AreEqual(double.MinValue, result);
        }

        [TestMethod]
        public void Min_WithDoubleMaxValue_ReturnsSmallest()
        {
            double result = _window.Min(double.MaxValue, 1e307, -5);
            Assert.AreEqual(-5, result);
        }

        [TestMethod]
        public void Min_WithZeroAndNegative_ReturnsNegative()
        {
            double result = _window.Min(0.0, -0.1, 0.0);
            Assert.AreEqual(-0.1, result);
        }

        [TestMethod]
        public void Min_WithPrecision_ReturnsCorrect()
        {
            double result = _window.Min(0.1, 0.2, 0.30000000000000004);
            Assert.AreEqual(0.1, result);
        }
    }
}

