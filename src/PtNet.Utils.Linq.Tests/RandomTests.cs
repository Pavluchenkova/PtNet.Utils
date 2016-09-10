using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PtNet.Utils.Linq.Tests
{
    [TestClass]
    public class RandomTests
    {
        private readonly int[] _testArray = { 3, 10, 2, 9, 5, 7, 1, 4, 6, 8 };
        
        [TestMethod]
        public void Shuffle_should_return_collection_not_equal_input()
        {
            var notExpected = _testArray;

            var actual = _testArray.Shuffle();

            Assert.AreNotEqual(notExpected, actual);
        }
    }
}
