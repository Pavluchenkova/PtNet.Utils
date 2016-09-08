using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace PtNet.Utils.Linq.Tests
{
    [TestClass]
    public class FirstOrDefinedTests
    {
        private readonly int[] _testArray = { 3, 10, 3, 2, 9, 10, 5, 7, 1, 4, 6, 8 };

        [TestMethod]
        public void FirstOrDefined_should_return_defined_value_with_empty_collection()
        {
            var emptyRefTypeCollection = new List<FakeClass>();
            var emptyValueTypeCollection = new List<int>();

            var expectedRefType = new FakeClass(10);
            var expectedValueType = 10;

            var actualRefType = emptyRefTypeCollection.FirstOrDefined(expectedRefType);
            var actualValueType = emptyValueTypeCollection.FirstOrDefined(expectedValueType);

            Assert.AreEqual(expectedRefType, actualRefType);
            Assert.AreEqual(expectedValueType, actualValueType);
        }

        [TestMethod]
        public void FirstOrDefined_should_return_first_value_from_collection()
        {
            var expected = 3;
            var actual = _testArray.FirstOrDefined(77);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FirstOrDefined_should_return_first_value_from_collection_by_predicate()
        {
            var expected = 2;
            var actual = _testArray.FirstOrDefined(i => i == 2, 77);

            Assert.AreEqual(expected, actual);
        }
    }
}
