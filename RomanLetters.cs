using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RomanLetters
{
    [TestClass]
    public class RomanLetters
    {

        [TestMethod]
        public void TestNumberLowerThanFour()
        {
            Assert.AreEqual("III", convertNumber(3));
        }
        [TestMethod]
        public void TestNumberFour()
        {
            Assert.AreEqual("IV", convertNumber(4));
        }
        [TestMethod]
        public void TestNumberEight()
        {
            Assert.AreEqual("VIII", convertNumber(8));
        }
        [TestMethod]
        public void TestNumberNine()
        {
            Assert.AreEqual("IX", convertNumber(9));
        }
        [TestMethod]
        public void TestNumberFifteen()
        {
            Assert.AreEqual("XV", convertNumber(15));
        }
        [TestMethod]
        public void TestNumberThirty()
        {
            Assert.AreEqual("XXX", convertNumber(30));
        }
        [TestMethod]
        public void TestNumberThirtyNine()
        {
            Assert.AreEqual("XXXIX", convertNumber(39));
        }
        [TestMethod]
        public void TestNumberFortyOne()
        {
            Assert.AreEqual("XLI", convertNumber(41));
        }
        [TestMethod]
        public void TestNumberFortyFive()
        {
            Assert.AreEqual("XLV", convertNumber(45));
        }
        [TestMethod]
        public void TestNumberNinetyNine()
        {
            Assert.AreEqual("XCIX", convertNumber(99));
        }
        [TestMethod]
        public void TestNumberOneHundred()
        {
            Assert.AreEqual("C", convertNumber(100));
        }
        [TestMethod]
        public void TestNumberOutOfRange()
        {
            Assert.AreEqual("ERROR!", convertNumber(101));
        }

    }
}
