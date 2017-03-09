using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace cable_puzzle
{
    public class CablePuzzleGame
    {
        public List<Piece> pieces = new List<Piece>();
        public int solutionIndex;
        public Solution solution;
        public bool solved = false;

        public CablePuzzleGame(List<string> pieces = null) {
            Random ran = new Random();
            solutionIndex = ran.Next(Solution.predefs.Count);
            solution = Solution.predefs[solutionIndex];
            
            pieces = pieces ?? generateDefaultPieces();
            foreach (string pp in pieces) {                
                this.pieces.Add(new Piece(pp));
            }                        
        }

        public List<string> generateDefaultPieces() {
            Random ran = new Random();
            var piecesTemplate = solution.generateTemplate();
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
            solution = solution ?? this.solution.pieces;
            solutionPath = solutionPath ?? this.solution.path;
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
