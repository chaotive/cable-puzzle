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
                    "10", "12", "01",
                    "13", "00", "12"
                },
                new List<int> {
                    0, 1, 4,
                    3, 6, 7,
                    8, 5, 2
                },
                new Pins(PinPosition.Up, PinPosition.Up)
            ),
            new Solution(
                new List<string> {
                    "11", "10", "11",
                    "13", "12", "13",
                    "13", "00", "00"
                },
                new List<int> {
                    0, 3, 4,
                    1, 2, 5
                },
                new Pins(PinPosition.Up, PinPosition.Middle)
            ),
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
            ),

            new Solution(
                new List<string> {
                    "10", "11", "10",
                    "12", "01", "01",
                    "13", "13", "12"
                },
                new List<int> {
                    3, 0, 1,
                    4, 7, 8,
                    5, 2
                },
                new Pins(PinPosition.Middle, PinPosition.Up)
            ),
            new Solution(
                new List<string> {
                    "11", "10", "11",
                    "00", "11", "10",
                    "13", "13", "12"
                },
                new List<int> {
                    3, 4, 7,
                    8, 5
                },
                new Pins(PinPosition.Middle, PinPosition.Middle)
            ),
            new Solution(
                new List<string> {
                    "10", "10", "11",
                    "00", "12", "01",
                    "13", "00", "13"
                },
                new List<int> {
                    3, 4, 1,
                    2, 5, 8
                },
                new Pins(PinPosition.Middle, PinPosition.Down)
            ),
            new Solution(
                new List<string> {
                    "10", "00", "00",
                    "13", "11", "01",
                    "00", "12", "12"
                },
                new List<int> {
                    6, 7, 4,
                    3, 0, 1,
                    2
                },
                new Pins(PinPosition.Down, PinPosition.Up)
            ),
            new Solution(
                new List<string> {
                    "11", "10", "11",
                    "10", "11", "10",
                    "12", "13", "12"
                },
                new List<int> {
                    6, 3, 4,
                    7, 8, 5
                },
                new Pins(PinPosition.Down, PinPosition.Middle)
            ),
            new Solution(
                new List<string> {
                    "10", "11", "11",
                    "01", "13", "11",
                    "12", "00", "13"
                },
                new List<int> {
                    6, 3, 0,
                    1, 4, 5,
                    8
                },
                new Pins(PinPosition.Down, PinPosition.Down)
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
