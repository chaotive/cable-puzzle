using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using cable_puzzle;
using System.Diagnostics;
using System.Collections.Generic;

namespace cable_puzzle_test
{
    [TestClass]
    public class CablePuzzleTest
    {
        [TestMethod]
        public void cablePuzzleConstructor()
        {            
            var cp = new CablePuzzle(new List<string> {"00", "01"});

            Assert.AreEqual(Piece.Type.Straight, cp.pieces[0].type);
            Assert.AreEqual(Piece.Orientation.Right, cp.pieces[0].orientation);

            Assert.AreEqual(Piece.Type.Straight, cp.pieces[1].type);
            Assert.AreEqual(Piece.Orientation.Down, cp.pieces[1].orientation);
        }
    }
}
