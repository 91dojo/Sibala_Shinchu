using System;
using System.Collections.Generic;
using System.IO;
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

            var dicTemp = from val in input
                group val by val into v1
                select new KeyValuePair<int, int>(v1.Key, v1.Count());

            if(dicTemp.Count()>2)
                sum = dicTemp.Where(o => o.Value == 1).Select(o=>o.Key).Sum();
            else if(dicTemp.Count()==2)
            {
                int bigger = dicTemp.Select(o => o.Key).Max();
                sum = bigger * 2;
            }
            else if (dicTemp.Count() == 1)
                return "same color";

            if (sum == 3)
                return "BG";
            else if (sum == 12)
                return "Sibala";

            return $"{sum} points";
        }

        public IEnumerable<DiceDto> ReturnDices()
        {
            throw new NotImplementedException();
        }
    }
}