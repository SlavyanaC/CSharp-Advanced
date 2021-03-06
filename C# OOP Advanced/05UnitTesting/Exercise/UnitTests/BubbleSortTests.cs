﻿namespace UnitTests
{
    using NUnit.Framework;
    using P04BubbleSort;
    using System.Collections.Generic;

    public class BubbleSortTests
    {
        private List<int> randomList;
        private List<int> expectedList;
        private Bubble bubble;

        [SetUp]
        public void InitTest()
        {
            this.bubble = new Bubble();
            this.randomList = new List<int>() { 14, 55, 12, 13, 9, 91, 43, 35, 70, 29, 72, 39, 21, 51, 60, 57, 75, 41, 73, 42, 16, 34, 2, 37, 7, 31, 18, 62, 10, 89, 90, 92, 5, 100, 64, 23, 78, 58, 82, 17, 79, 53, 30, 19, 22, 59, 44, 97, 86, 28, 26, 49, 47, 24, 40, 20, 80, 46, 48, 84, 99, 98, 45, 32, 27, 81, 50, 11, 87, 54, 52, 36, 8, 85, 71, 56, 1, 88, 68, 4, 61, 93, 33, 76, 74, 95, 96, 25, 77, 63, 66, 69, 6, 3, 38, 15, 65, 83, 67, 94 };

            this.expectedList = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 58, 59, 60, 61, 62, 63, 64, 65, 66, 67, 68, 69, 70, 71, 72, 73, 74, 75, 76, 77, 78, 79, 80, 81, 82, 83, 84, 85, 86, 87, 88, 89, 90, 91, 92, 93, 94, 95, 96, 97, 98, 99, 100 };
        }

        [Test]
        public void TestSortWithRandomGeneratadNumbers()
        {
            var actualList = this.bubble.Sort(this.randomList);

            Assert.AreEqual(this.expectedList, actualList);
        }

        [Test]
        public void TestSortWithBuildInSortForList()
        {
            var actualList = this.bubble.Sort(this.randomList);
            this.randomList.Sort();

            Assert.AreEqual(randomList, actualList);
        }
    }
}
