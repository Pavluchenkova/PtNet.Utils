using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace PtNet.Utils.Linq.Tests
{
    [TestClass]
    public class FirstOrDefinedTests
    {
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
            throw new NotImplementedException();
        }
    }
}
