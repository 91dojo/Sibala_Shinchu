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
            if (diceA.Status == diceB.Status)
                return 0;

            throw new NotImplementedException();
        }
    }
}