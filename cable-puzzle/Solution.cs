using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace cable_puzzle
{
    public enum PinPosition { Up, Middle, Down }

    public struct Pins {
        public PinPosition startPin;
        public PinPosition endPin;

        public Pins(PinPosition startPin, PinPosition endPin) {
            this.startPin = startPin;
            this.endPin = endPin;
        }
    }

    public class Solution
    {
        public static List<Solution> predefs = new List<Solution>(){
            new Solution(
                new List<string> {
                    "00", "11", "10",
                    "11", "12", "01",
                    "13", "00", "12"
                },
                new List<int> {
                    0, 1, 4,
                    3, 6, 7,
                    8, 5, 2
                },
                new Pins(PinPosition.Up, PinPosition.Up)
            ),
            /*new Solution(
                new List<string> {
                    "00", "00", "11",
                    "10", "00", "12",
                    "13", "00", "00"
                },
                new List<int> {
                    0, 1, 2,
                    5, 4, 3,
                    6, 7, 8
                },
                new Pins(PinPosition.Up, PinPosition.Middle)
            ),*/
            new Solution(
                new List<string> {
                    "00", "00", "11",
                    "10", "00", "12",
                    "13", "00", "00"
                },
                new List<int> {
                    0, 1, 2,
                    5, 4, 3,
                    6, 7, 8
                },
                new Pins(PinPosition.Up, PinPosition.Down)
            )
        };

        public List<string> pieces;
        public List<int> path;
        public Pins pins;

        public Solution(List<string> pieces, List<int> path, Pins pins) {
            this.pieces = pieces;
            this.path = path;
            this.pins = pins;
        }

        public List<string> generateTemplate() {
            return pieces.Select(p => p.Substring(0,1)).ToList();            
        }
    }
}
