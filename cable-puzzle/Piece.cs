using System;
using System.Diagnostics;

namespace cable_puzzle
{    
    public class Piece
    {
        public enum Type { Straight, Corner }
        public enum Orientation { Right, Down, Left, Up }

        public static int MaxOrientation = Enum.GetValues(typeof(Orientation)).Length;

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

            //Debug.WriteLine(this.type + " " + this.orientation);
        }

        public string getAsString() {
            return string.Concat((int)type, (int)orientation);
        }

    }
}
