using System;
using System.Collections.Generic;

namespace Sibala_Hsinchu
{
    internal class Dice
    {
        public Dice()
        {
        }

        public int Compare(DiceDto diceA, DiceDto diceB)
        {
            var statusA = (int)diceA.Status;
            var statusB = (int)diceB.Status;
            if (statusA < statusB)
                return 1;

            if (statusA > statusB)
                return -1;

            if (diceA.Status == diceB.Status)
            {

                //if (diceA.Status == DiceDto.StatusEnum.SameColor)
                //{
                //    var samecolororder = new List<int> { 1, 4, 6, 5, 3, 2 };
                //    var dnumber = diceA.DicePoints)/4;
                //    if (samecolororder.IndexOf(dnumber);

                //}

                if (diceA.DicePoints == diceB.DicePoints)
                    return 0;
                if (diceA.DicePoints > diceB.DicePoints)
                    return 1;
                if (diceA.DicePoints < diceB.DicePoints)
                    return -1;

            }
            return 0;


            throw new NotImplementedException();
        }
    }
}