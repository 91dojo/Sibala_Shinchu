using System;

namespace Sibala_Hsinchu
{
    internal class Dice
    {
        public Dice()
        {
        }

        public int Compare(DiceDto diceA, DiceDto diceB)
        {
            var statusA = (int) diceA.Status;
            var statusB = (int)diceB.Status;
            if (statusA < statusB)
                return 1;

            if (statusA > statusB)
                return -1;

            if (diceA.Status == diceB.Status)
                return 0;

            throw new NotImplementedException();
        }
    }
}