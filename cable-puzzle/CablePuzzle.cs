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
        private List<string> defaultSolution = new List<string> {
            "00", "00", "11",
            "00", "10", "01",
            "00", "00", "13"
        };
        private List<int> defaultSolutionPath = new List<int> {
            0, 1, 2, 5, 8
        };
        public bool solved = false;

        public CablePuzzle(List<string> pieces = null) {
            pieces = pieces ?? generateDefaultPieces();
            foreach (string pp in pieces) {                
                this.pieces.Add(new Piece(pp));
            }                        
        }

        public static List<string> generateDefaultPieces() {
            Random ran = new Random();            
            var piecesTemplate = new List<string> {
                "0", "0", "1",
                "0", "1", "0",
                "0", "0", "1"
            };
            return piecesTemplate.Select(p => p + ran.Next(Piece.MaxOrientation)).ToList();
        }
              
        public Piece.Orientation rotate(int index) {  
            if ((int)pieces[index].orientation + 1 == Piece.MaxOrientation)
                pieces[index].orientation = 0;
            else
                pieces[index].orientation += 1;

            return pieces[index].orientation;
        }
        
        public bool checkSolved(List<string> solution = null, List<int> solutionPath = null) {
            Debug.WriteLine("checkSolved");
            solution = solution ?? defaultSolution;
            solutionPath = solutionPath ?? defaultSolutionPath;
            var allMatch = true;
            
            foreach (int pi in solutionPath) {
                if (allMatch) {
                    pieces[pi].matches = pieces[pi].Equals(solution[pi]);
                    if (!pieces[pi].matches) allMatch = false;                    
                }
                else pieces[pi].matches = false;
                Debug.WriteLine(pieces[pi]);
            }

            solved = allMatch;
            return solved;
        }
    }
}
