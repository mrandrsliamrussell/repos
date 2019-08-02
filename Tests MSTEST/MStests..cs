using Microsoft.VisualStudio.TestTools.UnitTesting;
using lab22_first_test;
namespace Tests_MSTEST
{
    [TestClass]
    public class MStests
    {
        [TestMethod]
        
        public void SumTotalOfArrayTest()
        {
            //arrange
            int[] myArray = { 10, 20, 30 };
            var expected = 60;
            var actual = LabWork.SumTotalOfArrayMembers(myArray);
            Assert.AreEqual(expected, actual);
        }
    }
}
