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
        public void constructor()
        {
            var cp = new CablePuzzle(new List<string> {"00", "01" });
            foreach(Piece p in cp.pieces) {
                Debug.Write(p.type + " " + p.orientation);
            }
        }
    }
}
