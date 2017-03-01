using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace cable_puzzle
{
    public class CablePuzzle
    {
        public List<Piece> pieces;

        public CablePuzzle(List<string> pieces) {
            foreach (string pp in pieces) {
                this.pieces.Add(new Piece(pp));
            }            
        }
    }
}
