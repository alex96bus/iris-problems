namespace IrisProblems.Tests
{
    [TestClass]
    public class BalancedBracketsUnitTests
    {
        private const string ValidExpectedResult = "Balanced";
        private const string InvalidExpectedResult = "Not Balanced";

        [TestMethod]
        [DataRow("()")]
        [DataRow("[]")]
        [DataRow("{}")]
        [DataRow("({[]})")]
        [DataRow("[{()}]")]
        [DataRow("[()]{}{[()()]()}")]
        [DataRow("[{()}][({})]{[{()}]}")]
        public void GivenABalancedBracketExpression_CheckExpressionWithList_ThenReturnsBalancedAsString(string expression)
        {
            //Arrange
            var service = new BalancedBracketsService();

            //Act
            string result = service.CheckExpressionWithList(expression);

            //Assert
            Assert.AreSame(ValidExpectedResult, result);
        }

        [TestMethod]
        [DataRow("()")]
        [DataRow("[]")]
        [DataRow("{}")]
        [DataRow("({[]})")]
        [DataRow("[{()}]")]
        [DataRow("[()]{}{[()()]()}")]
        [DataRow("[{()}][({})]{[{()}]}")]
        public void GivenABalancedBracketExpression_CheckExpressionWithStack_ThenReturnsBalancedAsString(string expression)
        {
            //Arrange
            var service = new BalancedBracketsService();

            //Act
            string result = service.CheckExpressionWithStack(expression);

            //Assert
            Assert.AreSame(ValidExpectedResult, result);
        }

        [TestMethod]
        [DataRow("")]
        [DataRow("(")]
        [DataRow(")")]
        [DataRow("[{")]
        [DataRow("[(])")]
        [DataRow("[{)}")]
        [DataRow("[{(})]")]
        public void GivenAnUnbalancedBracketExpression_CheckExpressionWithList_ThenReturnsNotBalancedAsString(string expression)
        {
            //Arrange
            var service = new BalancedBracketsService();

            //Act
            string result = service.CheckExpressionWithList(expression);

            //Assert
            Assert.AreSame(InvalidExpectedResult, result);
        }

        [TestMethod]
        [DataRow("(")]
        [DataRow(")")]
        [DataRow("[{")]
        [DataRow("[(])")]
        [DataRow("[{)}")]
        [DataRow("[{(})]")]
        [DataRow("")]
        public void GivenAnUnbalancedBracketExpression_CheckExpressionWithStack_ThenReturnsNotBalancedAsString(string expression)
        {
            //Arrange
            var service = new BalancedBracketsService();

            //Act
            string result = service.CheckExpressionWithStack(expression);

            //Assert
            Assert.AreSame(InvalidExpectedResult, result);
        }
    }
}