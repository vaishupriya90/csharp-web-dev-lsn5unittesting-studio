using Microsoft.VisualStudio.TestTools.UnitTesting;
using BalancedBracketsNS;

namespace BalancedBracketsTests
{
    [TestClass]
    public class BalancedBracketsTests
    {
        // TODO: Add tests to this file.

        [TestMethod]
        public void EmptyTest()
        {
            Assert.AreEqual(true, true);
        }
        [TestMethod]     
        public void HasOpenAndCloseBrackets()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[]"));
        }
        [TestMethod]
        public void HasOnlyOpenBracket()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("["));
        }
        [TestMethod]
        public void HasOnlyCloseBracket()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("]"));
        }
        [TestMethod]
        public void HasTwoOpenBrackets()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("[["));
        }
        [TestMethod]
        public void HasTwoCloseBrackets()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("]]"));
        }
        [TestMethod]
        public void HasTwoBalancedBrackets()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[[]]"));
        }
        [TestMethod]
        public void BracketsMisPlaced()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("]["));

        }
        [TestMethod]
        public void BracketMisplacedWithStings()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("Launch]Code["));

        }
    }
}
