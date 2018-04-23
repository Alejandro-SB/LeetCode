namespace LeetCodeTests.Parentheses
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using static LeetCode.Parentheses.Parentheses;

    [TestClass]
    public class ParenthesesTest
    {
        [TestMethod]
        [DataRow("()",true)]
        [DataRow("()[]{}", true)]
        [DataRow("(]", false)]
        [DataRow("([)]", false)]
        [DataRow("{[]}", true)]
        [DataRow("(",false)]
        public void Parentheses_Are_Closed_Correctly_Test(string paren, bool result)
        {
            Assert.AreEqual(IsValid(paren), result);
        }
    }
}
