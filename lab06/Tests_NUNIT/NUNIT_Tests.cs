using NUnit.Framework;
using lab22_first_test;
using Eng_35_Tests;

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
        //  [TestCase(0 , 0)]
        public void TestCubicNumbers(int x, int y, int z, int expected)
        {
            //arrange

            var instance = new LabWork();
            //act
            var actual = instance.CubeNumbers(x, y, z);
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
        public void GetLengthOfArray(int[] expected)
        {

            int[] myArray = { 1, 2, 3, 4, 5 };
            var actual = LabWork.GetLengthOfArray(myArray);
            Assert.AreEqual(actual, expected);
        }


        // [TestCase (new int[] { 10, 11, 12, 13, 14, 15, 16, 17, 18, 19 }, 370)]
        public void Mega_Multiple_Coding_Loops_Tests(int[] array, int expected)
        {
            //arrange

            //act
            var actual = Eng35Tests.Mega_Multiple_Coding_Loops(array);

            //assert
            Assert.AreEqual(expected, -1);
        }

        [TestCase(new int[] { 10, 10, 20, 15, 15, 20, 30, 20, 5, 15 }, 160)]
        public void SumOfArray(int[] array, int expected)
        {
            //arrange

            //act
            var actual = Eng35Tests.SumOfArray(array);

            //assert
            Assert.AreEqual(expected, actual);

        }
        [TestCase(5, 5, 2, 625)]
        public void MultiplyNumbers(double x, double y, double n, double expected)
        {
            //arrange

            //act
            var actual = Eng35Tests.MultiplyNumbers(x, y, n);

            //assert
            Assert.AreEqual(expected, actual);
        }



        [TestCase(new int[] { 8, 3, 7 }, new int[] { 3, 7, 8 })]

        public void SortArray(int[] inputArray, int[] expected)
        {
            //arrange

            //act
            var actual = Eng35Tests.SortArray(inputArray);

            //assert

            Assert.AreEqual(expected, actual);
        }

        [TestCase(2,24,5,4)]
        public void HowManyNumbersAreDivisable(int start, int end, int result, int expected)
        {
            //arrange

            //assert
            var actual = Eng35Tests.HowManyNumbersDivisableBy(start, end, result);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 10,20,30,40}, 1012)]

        public void ArrayLoopQueueStack(int[] input, int expected)
        {
            //arrange
            //assert
            var actual = Eng35Tests.ArrayLoopQueueStack(input);

            //assert
            Assert.AreEqual(expected, actual);

        }

    }
}