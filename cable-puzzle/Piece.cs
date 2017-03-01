using System;

namespace cable_puzzle
{    
    public class Piece
    {
        public enum Type { Straight, Rounded }
        public enum Orientation { Right, Down, Left, Up }

        public Type type;
        public Orientation orientation;

        public Piece(string typeAndOrientation) {
            init(
                (Type)Int32.Parse(typeAndOrientation.Substring(0, 1)),
                (Orientation)Int32.Parse(typeAndOrientation.Substring(1, 1))
                );
        }

        public Piece(Type type, Orientation orientation) {
            init(type, orientation);
        }

        private void init(Type type, Orientation orientation) {
            this.type = type;
            this.orientation = orientation;
        }
    }
}
