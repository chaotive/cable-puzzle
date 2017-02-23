namespace cable_puzzle
{
    public enum Orientation
    {
        Right,
        Top,
        Left,
        Down
    }

    public class Piece
    {
        public string type;
        public Orientation orientation;
    }
}
