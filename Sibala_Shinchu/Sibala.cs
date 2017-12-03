using System;
using System.Collections.Generic;
using System.Linq;

namespace Sibala_Hsinchu
{
    public class Sibala : ISibala
    {
        public int GetMaxPointExceptSameColor(List<int> source)
        {
            throw new NotImplementedException();
        }

        public string GetResult(IEnumerable<int> input)
        {
            int sum = default(int);
            var tranfrom = input.Distinct();
            if (tranfrom.Count() == 4)
                return "no points";

            var dicTemp = new Dictionary<int,int>();
            foreach (int val in input)
            {
                if(!dicTemp.ContainsKey(val))
                    dicTemp.Add(val,0);

                dicTemp[val]++;
            }
            sum = dicTemp.Where(o => o.Value == 1).Select(o=>o.Key).Sum();

            if (sum == 3)
            {
                return "BG";
            }
            return $"{sum} points";
        }

        public IEnumerable<DiceDto> ReturnDices()
        {
            throw new NotImplementedException();
        }
    }
}