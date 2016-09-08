using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PtNet.Utils.Linq.Tests
{
    [TestClass]
    public class SecondOrDefaultTests
    {
        private readonly int[] _testArray = { 3, 10, 2, 3, 9, 5, 7, 1, 4, 6, 8 };

        [TestMethod]
        public void SecondOrDefault_should_return_second_element_from_collection()
        {
            var expected = _testArray[1];

            var actual = _testArray.SecondOrDefault();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SecondOrDefault_should_return_second_element_from_collection_by_predicate()
        {
            var expected = 3;
            var actual = _testArray.Second(i => i == 3);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SecondOrDefault_should_return_default_value_with_empty_collection()
        {
            var emptyValueTypeCollection = new List<int>();
            var emptyRefTypeCollection = new List<FakeClass>();

            var actualValue = 0;
            var expectedValue = emptyValueTypeCollection.SecondOrDefault();

            FakeClass actualRef = null;
            var expectedRef = emptyRefTypeCollection.SecondOrDefault();

            Assert.AreEqual(actualValue, expectedValue);
            Assert.AreEqual(actualRef, expectedRef);
        }
    }
}
