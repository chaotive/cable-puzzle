using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using cable_puzzle;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;

namespace cable_puzzle_test
{
    [TestClass]
    public class CablePuzzleGameTest
    {
        [TestMethod]
        public void cablePuzzleConstructor()
        {            
            var cp = new CablePuzzleGame(new List<string> {"00", "01"});

            Assert.AreEqual(Piece.Type.Straight, cp.pieces[0].type);
            Assert.AreEqual(Piece.Orientation.Right, cp.pieces[0].orientation);

            Assert.AreEqual(Piece.Type.Straight, cp.pieces[1].type);
            Assert.AreEqual(Piece.Orientation.Down, cp.pieces[1].orientation);
        }

        [TestMethod]
        public void cablePuzzleRotate()
        {
            var cp = new CablePuzzleGame(new List<string> { "03" });

            Assert.AreEqual(Piece.Orientation.Right, cp.rotate(0));            
            Assert.AreEqual(Piece.Type.Straight, cp.pieces[0].type);
            Assert.AreEqual(Piece.Orientation.Right, cp.pieces[0].orientation);
        }

        [TestMethod]
        public void cablePuzzleCheckSolved()
        {            
            var pieces = new List<string> { "01" };
            var solutionPath = new List<int> { 0 };
            var cp = new CablePuzzleGame(pieces);

            Assert.AreEqual(false, cp.checkSolved(new List<string> { "02" }, solutionPath));
            Assert.AreEqual(true, cp.checkSolved(pieces, solutionPath));
            cp.pieces[0] = new Piece("03");
            Assert.AreEqual(true, cp.checkSolved(pieces, solutionPath));
         
            cp = new CablePuzzleGame();

            Assert.AreEqual(false, cp.checkSolved());            
            Assert.AreEqual(true, cp.checkSolved(cp.pieces.Select(p => p.getAsString()).ToList()));
        }

        [TestMethod]
        public void cablePuzzleGenerateDefaultPieces()
        {
            var pieces = CablePuzzleGame.generateDefaultPieces();
            pieces.ForEach(p => Debug.WriteLine(p));
        }
    }
}
