using NUnit.Framework;
using lab22_first_test;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

       // [TestCase(10,10,10,1000)]
       // [TestCase(10,11,12,1320)]
       // [TestCase(10,15,20,3000)]
        [TestCase(0 , 0)]
        public void TestCubicNumbers(int x, int y, int z, int expected)
        {
            //arrange
            
            var instance = new LabWork();
            //act
            var actual = instance.CubeNumbers(x,y,z);
            //assert
           // Assert.AreEqual(expected, actual);
        }
        public void TestCubicNumbersStaticTest(int x, int y, int z, int expected)
        {
            //arrange

            
            //act
            var actual = LabWork.CubeNumbersStatic(x, y, z);
            //assert
            //Assert.AreEqual(expected, actual);
        }
        public void GetLengthOfArray( int[] expected)
        {
            
            int[] myArray = { 1, 2, 3, 4, 5 };
        var actual = LabWork.GetLengthOfArray(myArray);
        Assert.AreEqual(actual, expected);
        }
    }
}