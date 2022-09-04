using Microsoft.VisualStudio.TestTools.UnitTesting;
using BalancedBracketsNS;

namespace BalancedBracketsTests
{
    [TestClass]
    public class BalancedBracketsTests
    {
        [TestMethod]
        public void EmptyTest()
        {
            Assert.AreEqual(true, true);
        }

        // Test 1
        [TestMethod]
        public void OnlyBracketsReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[]"));
        }

        // Test 2
        [TestMethod]
        public void NoBracketsReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets(""));
        }

        // Test 3
        [TestMethod]
        public void BracketsWithStringReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[LaunchCode]"));
        }
        
        // Test 4
        [TestMethod]
        public void OnlySingleBracketAtStartReturnsFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("[LaunchCode"));
        }

        // Test 5
        [TestMethod]
        public void OnlySingleBracketAtEndReturnsFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("LaunchCode]"));
        }

        // Test 6
        [TestMethod]
        public void ReversedBracketsReturnsFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("]["));
        }

        // Test 7
        [TestMethod]
        public void MisplacedBracketsWithStringReturnsFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("La]unchC[ode"));
        }

        // Test 8
        [TestMethod]
        public void StringOutsideOfBracketsReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[]LaunchCode"));
        }

        // Test 9
        [TestMethod]
        public void PartialStringInBracketsReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[Launch]Code"));
        }


        // Test 10
        [TestMethod]
        public void NestedBracketsInOrderReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[[]]"));
        }


        // Test 11
        [TestMethod]
        public void NestedBracketsReversedReturnsFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("]][["));
        }

        // Test 12
        [TestMethod]
        public void PairOfBracketsReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[][]"));
        }

    }
}
