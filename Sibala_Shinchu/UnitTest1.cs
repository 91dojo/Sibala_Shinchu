using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Sibala_Hsinchu
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CompareTest_1_Same_1_Same()
        {
            var target = new Dice();
            var diceA = new DiceDto()
            {
                Status = DiceDto.StatusEnum.SameColor,
                DicePoints = 1
            };
            var diceB = new DiceDto()
            {
                Status = DiceDto.StatusEnum.SameColor,
                DicePoints = 1
            };

            var expected = 0;

            var actual = target.Compare(diceA, diceB);

            Assert.AreEqual(expected, actual);
        }
    }
}