using System.Collections.Generic;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Sibala_Hsinchu
{
    [TestClass]
    public class SibalaTest
    {
        private IEnumerable<int> input;

        [TestMethod]
        public void GetResult_input_1_2_3_4_should_be_no_points()
        {
            input = new List<int> {1, 2, 3, 4};
            var target = new Sibala();
            var actual = target.GetResult(input);
            var expected = "no points";
            Assert.AreEqual(expected,actual);
        }
        [TestMethod]
        public void GetResult_input_1_2_3_1_Should_Be_5_points()
        {
            //arrange
            input = new List<int> { 1, 2, 3, 1 };
            var target = new Sibala();
            var expected = "5 points";

            //act
            var actual = target.GetResult(input);
            
            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}