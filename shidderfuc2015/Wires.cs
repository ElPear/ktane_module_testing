using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ktane
{
    public class Wires
    {
        public Wires(Bomb bomb) { bombPeriphs = bomb; }
        private Bomb bombPeriphs;
        private readonly string[] validColors = { "RED", "YELLOW", "BLUE", "WHITE", "BLACK" };
        private string[] inputColors = Array.Empty<string>();


        // if there were are wires where 2 are blue and 1 is red you would say "blue blue red" 
        public void SetColors(string input)
        {
            string[] inputs = input.Trim().ToUpper().Split(" ");
            foreach (string item in inputs) 
            {
                if (validColors.Contains(item))
                {
                    inputColors = inputColors.Append(item).ToArray();
                }
            }
        }
        public void ResetColors()
        {
            inputColors = Array.Empty<string>();
        }
        public string SolveModule()
        {
            bool serialOdd = bombPeriphs.Serial[5] % 2 == 1;


            switch (inputColors.Length)
            {
                case 3:
                    if (inputColors.SequenceEqual("BLUE BLUE RED".Split(" ")))
                        return "Cut 2nd wire";
                    if (!(inputColors.Contains("RED")))
                        return "Cut 2nd wire";
                    return "Cut 3rd wire";

                case 4:
                    if (inputColors.Count(s => s == "RED") >= 2 && serialOdd)
                        return "Cut the last RED wire";
                    if (inputColors[3] == "YELLOW" && !inputColors.Contains("RED"))
                        return "Cut 1st wire";
                    if (inputColors.Count(s => s == "BLUE") == 1)
                        return "Cut 1st wire";
                    if (inputColors.Count(s => s == "YELLOW") >= 2)
                        return "Cut 4th wire";
                    return "Cut 2nd wire";

                case 5:
                    if (inputColors[4] == "BLACK" && serialOdd)
                        return "Cut 4th wire";
                    if (inputColors.Count(s => s == "RED") == 1 && inputColors.Count(s => s == "YELLOW") >= 2)
                        return "Cut 1st wire";
                    if (!inputColors.Contains("BLACK"))
                        return "Cut 2nd wire";
                    return "Cut 1st wire";

                case 6:
                    if (!inputColors.Contains("YELLOW") && serialOdd)
                        return "Cut 3rd wire";
                    if (inputColors.Count(s => s == "YELLOW") == 1 && inputColors.Count(s => s == "WHITE") >= 2)
                        return "Cut 4th wire";
                    if (!inputColors.Contains("RED"))
                        return "Cut 6th wire";
                    return "Cut 4th wire";

                default:
                    return "Invalid input";
            }
        }
    }
}
