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
        public void pieceConstructor()
        {
            var t = new Piece(Piece.Type.Straight, Piece.Orientation.Right);
            Assert.AreEqual(Piece.Type.Straight, t.type);
            Assert.AreEqual(Piece.Orientation.Right, t.orientation);

            t = new Piece("00");
            Assert.AreEqual(Piece.Type.Straight, t.type);
            Assert.AreEqual(Piece.Orientation.Right, t.orientation);

            t = new Piece("12");
            Assert.AreEqual(Piece.Type.Corner, t.type);
            Assert.AreEqual(Piece.Orientation.Left, t.orientation);
        }
    }
}
