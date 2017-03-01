using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace cable_puzzle
{
    public class CablePuzzle
    {
        public List<Piece> pieces = new List<Piece> {};
        public bool solved = false;

        public CablePuzzle(List<string> pieces) {
            
            foreach (string pp in pieces) {
                //Debug.WriteLine(pp);                
                this.pieces.Add(new Piece(pp));
            } 
                       
        }
    }
}
