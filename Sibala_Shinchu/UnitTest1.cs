using System.Collections.Generic;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Sibala_Hsinchu
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GetResult_input_1_2_3_4_should_be_no_points()
        {
            var input = new List<int> {1, 2, 3, 4};
            var target = new Sibala();
            var actual = target.GetResult(input);
            var expected = "no points";
            Assert.AreEqual(expected,actual);
        }
    }
}