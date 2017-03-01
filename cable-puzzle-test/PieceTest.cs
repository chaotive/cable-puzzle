using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using cable_puzzle;
using System.Diagnostics;

namespace cable_puzzle_test
{
    [TestClass]
    public class PieceTest
    {
        [TestMethod]
        public void constructor()
        {
            var t = new Piece(Piece.Type.Straight, Piece.Orientation.Right);
            Debug.Write(t.type + " " + t.orientation);
        }
    }
}
