using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace cable_puzzle
{
    public class CablePuzzle
    {
        public List<Piece> pieces = new List<Piece>();
        public List<string> solution = new List<string> { "00", "01" };
        public bool solved = false;

        public CablePuzzle(List<string> pieces) {            
            foreach (string pp in pieces) {                
                this.pieces.Add(new Piece(pp));
            }                        
        }

        public Piece.Orientation rotate(int index) {  
            if ((int)pieces[index].orientation + 1 == Piece.MaxOrientation)
                pieces[index].orientation = 0;
            else
                pieces[index].orientation += 1;

            return pieces[index].orientation;
        }
        
        public bool checkSolved(List<string> solution = null) {            
            solution = solution ?? this.solution;                        
            solved = Enumerable.SequenceEqual(solution, pieces.Select(p => p.getAsString()));

            return solved;
        }
    }
}
