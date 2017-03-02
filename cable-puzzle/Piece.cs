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
        public bool matches;

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
            return getAsString(orientation);
        }

        public string getAsString(Orientation orientation) {
            return string.Concat((int)type, (int)orientation);
        }

        public override string ToString() {
            return "Piece(" + type + "," + orientation + "," + matches + ")";
        }

        public bool Equals(string piece) { return Equals(new Piece(piece)); }

        public bool Equals(Piece piece)
        {
            Debug.WriteLine("Comparing " + piece + " to " + ToString());
            
            if (piece.type == type) {
                if (type == Type.Straight & (orientation == Orientation.Left || orientation == Orientation.Right))
                    return piece.orientation == Orientation.Left || piece.orientation == Orientation.Right;
                else if (type == Type.Straight & (orientation == Orientation.Up || orientation == Orientation.Down))
                    return piece.orientation == Orientation.Up || piece.orientation == Orientation.Down;
                else return piece.orientation == orientation;
            }
            else return false;            
            
        }

    }
}
