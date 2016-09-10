using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PtNet.Utils.Linq.Tests
{
    [TestClass]
    public class WhereNotTests
    {
        private readonly int[] _testArray = { 3, 10, 2 };

        [TestMethod]
        public void WhereNot_should_filter_collection_not_including_predicate()
        {
            var expected = new[] { 3, 2 };
            var actual = _testArray.WhereNot(p => p == 10).ToArray();
            Assert.AreEqual(expected, actual);
        }
    }
}
