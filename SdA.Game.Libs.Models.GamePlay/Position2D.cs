namespace SdA.Game.Libs.Models.GamePlay
{
    public class Position2D
    {
        public int X { get; set; }

        public int Y { get; set; }

        public static bool operator ==(Position2D left, Position2D right)
        {
            return left.Y == right.Y && left.X == right.X;
        }

        public static bool operator !=(Position2D left, Position2D right)
        {
            return left.Y != right.Y && left.X != right.X;
        }
    }

    public record Position2DR(int X, int Y); // ValueObject => comparer par valeur (donc valeur des propriétés)
}
