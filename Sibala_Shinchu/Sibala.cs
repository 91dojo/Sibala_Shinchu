using System;
using System.Collections.Generic;

namespace Sibala_Hsinchu
{
    public class Sibala : ISibala
    {
        public string GetResult(List<int> input)
        {
            return "no points";
        }

        public List<DiceDto> ReturnDices()
        {
            throw new NotImplementedException();
        }
    }
}