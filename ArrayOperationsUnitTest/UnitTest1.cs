using Arrays_Processing;

namespace ArrayOperationsUnitTest
{
    [TestClass]
    public class Test_ArrayOperations
    {
        [TestMethod]
        public void Test_Clear()
        {
            // Arrange.
            int size = 10;
            int min = 0;
            int max = 1000;

            ArrayOperations arr1 = new ArrayOperations();
            ArrayOperations arr2 = new ArrayOperations();
            ArrayOperations arr3 = new ArrayOperations();

            arr1.GenerateArray(size, min, max);
            arr2.GenerateArray(size, min, max);
            arr3.GenerateArray(size, min, max);

            // Act.
            arr1.Clear();
            arr2.Clear();
            arr3.Clear();

            // Assert.
            Assert.AreEqual(null, arr1.Value);
            Assert.AreEqual(null, arr2.Value);
            Assert.AreEqual(null, arr3.Value);
        }

        [TestMethod]
        public void Test_OperationOne()
        {
            // Arrange.
            ArrayOperations arr1 = new ArrayOperations();
            ArrayOperations arr2 = new ArrayOperations();
            ArrayOperations arr3 = new ArrayOperations();

            arr1.Value = new int[] { 1, 5, 10, 20 };
            arr2.Value = new int[] { 50, 3, 11, 23 };
            arr3.Value = new int[] { 61, 7, 14, 11 };

            // Act.
            int[] res1 = arr1.OperationOne();
            int[] res2 = arr2.OperationOne();
            int[] res3 = arr3.OperationOne();


            // Assert.
            int[] act1 = { 1, 20, 10 };
            int[] act2 = { 3, 50, 25 };
            int[] act3 = { 7, 61, 30 };

            Assert.IsTrue(res1.SequenceEqual(act1));
            Assert.IsTrue(res2.SequenceEqual(act2));
            Assert.IsTrue(res3.SequenceEqual(act3));
        }

        [TestMethod]
        public void Test_OperationTwo()
        {
            // Arrange.
            ArrayOperations arr1 = new ArrayOperations();
            ArrayOperations arr2 = new ArrayOperations();
            ArrayOperations arr3 = new ArrayOperations();

            arr1.Value = new int[] { 1, 5, 10, 20 };
            arr2.Value = new int[] { 50, 3, 11, 23 };
            arr3.Value = new int[] { 61, 7, 14, 11 };

            // Act.
            arr1.OperationTwo();
            arr2.OperationTwo();
            arr3.OperationTwo();


            // Assert.
            int[] act1 = { 20, 10, 5, 1 };
            int[] act2 = { 50, 23, 11, 3 };
            int[] act3 = { 61, 14, 11, 7 };

            Assert.IsTrue(arr1.Value.SequenceEqual(act1));
            Assert.IsTrue(arr2.Value.SequenceEqual(act2));
            Assert.IsTrue(arr3.Value.SequenceEqual(act3));
        }

        [TestMethod]
        public void Test_OperationThree()
        {
            // Arrange.
            ArrayOperations arr1 = new ArrayOperations();
            ArrayOperations arr2 = new ArrayOperations();
            ArrayOperations arr3 = new ArrayOperations();

            arr1.Value = new int[] { 46, 51, 104, 359 };
            arr2.Value = new int[] { 232, 174, 140, 68 };
            arr3.Value = new int[] { 287, 198, 336, 64 };

            // Act.
            int[] res1 = arr1.OperationThree();
            int[] res2 = arr2.OperationThree();
            int[] res3 = arr3.OperationThree();


            // Assert.
            int[] act1 = { 1, 359 };
            int[] act2 = { 1, 232 };
            int[] act3 = { 0, 0 };

            Assert.IsTrue(res1.SequenceEqual(act1));
            Assert.IsTrue(res2.SequenceEqual(act2));
            Assert.IsTrue(res3.SequenceEqual(act3));
        }

        [TestMethod]
        public void Test_OperationFour()
        {
            // Arrange.
            ArrayOperations arr1 = new ArrayOperations();
            ArrayOperations arr2 = new ArrayOperations();
            ArrayOperations arr3 = new ArrayOperations();

            arr1.Value = new int[] { 46, 51, 104, 359 };
            arr2.Value = new int[] { 232, 174, 140, 68 };
            arr3.Value = new int[] { 287, 198, 336, 64 };

            // Act.
            int[] res1 = arr1.OperationFour();
            int[] res2 = arr2.OperationFour();
            int[] res3 = arr3.OperationFour();


            // Assert.
            int[] act1 = { 1, 46 };
            int[] act2 = { 2, 372 };
            int[] act3 = { 3, 549 };

            Assert.IsTrue(res1.SequenceEqual(act1));
            Assert.IsTrue(res2.SequenceEqual(act2));
            Assert.IsTrue(res3.SequenceEqual(act3));
        }
    }
}