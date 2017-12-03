using System.Collections.Generic;

namespace Sibala_Hsinchu
{
    public interface ISibala
    {
        IEnumerable<DiceDto> ReturnDices();

        int GetMaxPointExceptSameColor(List<int> source);
    }
}