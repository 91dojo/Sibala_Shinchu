﻿using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Sibala_Hsinchu
{
    [TestClass]
    public class DiceTests
    {
        [TestMethod]
        public void CompareTest_1_Same_1_Same_should_be_0()
        {
            var diceA = new DiceDto(1, DiceDto.StatusEnum.SameColor);
            var diceB = new DiceDto(1, DiceDto.StatusEnum.SameColor);
            var expected = 0;
            CompareAreEqual(diceA, diceB, expected);
        }
        [TestMethod]
        public void CompareTest_1_Same_1_Point_should_be_1()
        {
            var diceA = new DiceDto(1, DiceDto.StatusEnum.SameColor);
            var diceB = new DiceDto(1, DiceDto.StatusEnum.Points);
            var expected = 1;
            CompareAreEqual(diceA, diceB, expected);
        }
        [TestMethod]
        public void CompareTest_1_Point_1_NoPoint_should_be_1()
        {
            var diceA = new DiceDto(1, DiceDto.StatusEnum.Points);
            var diceB = new DiceDto(1, DiceDto.StatusEnum.NoPoints);
            var expected = 1;
            CompareAreEqual(diceA, diceB, expected);
        }
        [TestMethod]
        public void CompareTest_1_Same_1_NoPoint_should_be_1()
        {
            var diceA = new DiceDto(1, DiceDto.StatusEnum.SameColor);
            var diceB = new DiceDto(1, DiceDto.StatusEnum.NoPoints);
            var expected = 1;
            CompareAreEqual(diceA, diceB, expected);
        }

        [TestMethod]
        public void CompareTest_3_Same_2_Same_should_be_1()
        {
            var diceA = new DiceDto(3, DiceDto.StatusEnum.SameColor);
            var diceB = new DiceDto(2, DiceDto.StatusEnum.SameColor);
            var expected = 1;
            CompareAreEqual(diceA, diceB, expected);
        }


        [TestMethod]
        public void CompareTest_2_Same_3_Same_should_be_n1()
        {
            var diceA = new DiceDto(2, DiceDto.StatusEnum.SameColor);
            var diceB = new DiceDto(3, DiceDto.StatusEnum.SameColor);
            var expected = -1;
            CompareAreEqual(diceA, diceB, expected);
        }


        //[TestMethod]
        //public void CompareTest_1_Same_4_Same_should_be_n1()
        //{
        //    var diceA = new DiceDto(1, DiceDto.StatusEnum.SameColor);
        //    var diceB = new DiceDto(4, DiceDto.StatusEnum.SameColor);
        //    var expected = 1;
        //    CompareAreEqual(diceA, diceB, expected);
        //}

        //[TestMethod]
        //public void CompareTest_4_Same_2_Same_should_be_n1()
        //{
        //    var diceA = new DiceDto(4, DiceDto.StatusEnum.SameColor);
        //    var diceB = new DiceDto(2, DiceDto.StatusEnum.SameColor);
        //    var expected = 1;
        //    CompareAreEqual(diceA, diceB, expected);
        //}

        //[TestMethod]
        //public void CompareTest_1_Same_2_Same_should_be_n1()
        //{
        //    var diceA = new DiceDto(1, DiceDto.StatusEnum.SameColor);
        //    var diceB = new DiceDto(2, DiceDto.StatusEnum.SameColor);
        //    var expected = 1;
        //    CompareAreEqual(diceA, diceB, expected);
        //}

//[TestMethod]
//        public void CompareTest_4_Same_5_Same_should_be_n1()
//        {
//            var diceA = new DiceDto(4, DiceDto.StatusEnum.SameColor);
//            var diceB = new DiceDto(5, DiceDto.StatusEnum.SameColor);
//            var expected = 1;
//            CompareAreEqual(diceA, diceB, expected);
//        }

        private static void CompareAreEqual(DiceDto diceA, DiceDto diceB, int expected)
        {
            var target = new Dice();
            var actual = target.Compare(diceA, diceB);
            Assert.AreEqual(expected, actual);
        }
    }
}