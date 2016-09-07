using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace PtNet.Utils.Linq.Tests
{
    [TestClass]
    public class OrderByTests
    {
        private readonly int[] _testArray = { 3, 10, 2, 9, 5, 7, 1, 4, 6, 8 };

        [TestMethod]
        public void OrderBy_Ascending_should_sort_collection_properly()
        {
            var expected = _testArray.OrderBy(i => i);

            var actual = _testArray.OrderBy(i => i, SortingDirection.Ascending);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void OrderBy_Descending_should_sort_collection_properly()
        {
            var expected = _testArray.OrderByDescending(i => i);

            var actual = _testArray.OrderBy(i => i, SortingDirection.Ascending);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void OrderBy_with_multiple_predicates_should_sort_collection_properly()
        {
            throw new NotImplementedException();
        }
    }
}
