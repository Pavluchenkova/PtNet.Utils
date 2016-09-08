using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PtNet.Utils.Linq.Tests
{
    [TestClass]
    public class GuardTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ArgumentNotNull_shold_rise_ArgumentNullException_while_argument_is_null()
        {
            FakeClass argument = null;

            Guard.ArgumentNotNull(argument, nameof(argument));
        }
    }
}
