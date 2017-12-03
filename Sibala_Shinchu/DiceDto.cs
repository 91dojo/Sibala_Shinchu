namespace Sibala_Hsinchu
{
    public class DiceDto
    {
        public enum StatusEnum { SameColor, NoPoints, Points }

        public StatusEnum Status { get; set; }
        public int DicePoints { get; set; }
    }
}