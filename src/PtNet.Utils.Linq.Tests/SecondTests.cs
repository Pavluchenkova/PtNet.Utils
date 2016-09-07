using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PtNet.Utils.Linq.Tests
{
    [TestClass]
    public class SecondTests
    {
        private readonly int[] _testArray = { 3, 10, 2, 9, 5, 7, 1, 4, 6, 8 };

        [TestMethod]
        public void Second_should_return_second_element_in_collection()
        {
            var expected = _testArray[1];

            var actual = _testArray.Second();

            Assert.AreEqual(expected, actual);
        }
        
        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Second_should_rise_InvalidOperationException_with_empty_collection()
        {
            var emptyCollection = new List<int>();

            emptyCollection.Second();
        }
    }
}
