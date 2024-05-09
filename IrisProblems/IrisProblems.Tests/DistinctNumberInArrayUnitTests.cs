namespace IrisProblems.Tests
{
    [TestClass]
    public class DistinctNumberInArrayUnitTests
    {
        [TestMethod]
        [DataRow(new int[] { 1 }, 1)]
        [DataRow(new int[] { 0, 1, 1 }, 0)]
        [DataRow(new int[] { 2, 2, 1 }, 1)]
        [DataRow(new int[]{ 0, 0, 1, 2, 2 }, 1)]
        [DataRow(new int[] { 3, 3, 4, 1, 1 }, 4)]
        public void GivenANonEmptyArrayOfInts_GetDistinctElementLINQ_ThenReturnsDistinctInt(int[] nums, int expectedResult)
        {
            //Arrange
            var service = new DistinctElementCheckerService();

            //Act
            int result = service.GetDistinctElementLINQ(nums);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        [DataRow(new int[] { 1 }, 1)]
        [DataRow(new int[] { 0, 1, 1 }, 0)]
        [DataRow(new int[] { 2, 2, 1 }, 1)]
        [DataRow(new int[] { 0, 0, 1, 2, 2 }, 1)]
        [DataRow(new int[] { 3, 3, 4, 1, 1 }, 4)]
        public void GivenANonEmptyArrayOfInts_GetDistinctElementXOR_ThenReturnsDistinctInt(int[] nums, int expectedResult)
        {
            //Arrange
            var service = new DistinctElementCheckerService();

            //Act
            int result = service.GetDistinctElementXOR(nums);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        [DataRow(new int[] { 1, 1 }, 0)]
        [DataRow(new int[] { 0, 0, 1, 1 }, 0)]
        [DataRow(new int[] { 2, 2, 1, 1 }, 0)]
        [DataRow(new int[] { 0, 0, 1, 2, 2, 1 }, 0)]
        public void GivenANonEmptyArrayOfIntsWithoutDistinctElement_GetDistinctElementLINQ_ThenReturnsZero(int[] nums, int expectedResult)
        {
            //Arrange
            var service = new DistinctElementCheckerService();

            //Act
            int result = service.GetDistinctElementLINQ(nums);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        [DataRow(new int[] { 1, 1 }, 0)]
        [DataRow(new int[] { 0, 0, 1, 1 }, 0)]
        [DataRow(new int[] { 2, 2, 1, 1 }, 0)]
        [DataRow(new int[] { 0, 0, 1, 2, 2, 1 }, 0)]
        public void GivenANonEmptyArrayOfIntsWithoutDistinctElement_GetDistinctElementXOR_ThenReturnsZero(int[] nums, int expectedResult)
        {
            //Arrange
            var service = new DistinctElementCheckerService();

            //Act
            int result = service.GetDistinctElementXOR(nums);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }
    }
}
