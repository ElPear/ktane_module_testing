using System.Linq;

namespace ktane_module_testing
{
    public class Memory
    {
        private int[] _numberSequence = Array.Empty<int>();
        private int[] _positionSequence = Array.Empty<int>();
        private string _smallNumbers = "";
        private string _display = "";
        private int _stage = 0;
        private static string CleanString(string input)
        {
            string[] stringNumbers = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            for (int i = 0; i < stringNumbers.Length; i++)
            {
                try
                {
                    input = input.Replace(i.ToString(), stringNumbers[i]);
                }
                catch { }
            }

            return input;
        }
        public void GetSmallNumbers(string input)
        {
            input = CleanString(input);
            string[] items = input.Split(' ');
            foreach (string item in items) 
            {
                if (int.TryParse(item, out int temp))
                {
                    _smallNumbers += temp.ToString();
                }
                
            }
        }
        public void GetDisplay(string input)
        {
            input = CleanString(input);
            string[] items = input.Split(' ');
            foreach (string item in items)
            {
                if (int.TryParse(item, out int temp))
                {
                    _display += temp;
                    break;
                }
            }
        }
        public string GetSolution()
        {
            int stage1Label = _numberSequence[0];
            int stage2Label = _numberSequence[1];
            int stage3Label = _numberSequence[2];
            int stage4Label = _numberSequence[3];
            
            string solution = "Error";

            switch (_stage)
            {
                case 0:
                    switch (_display)
                    {
                        case "1":
                            _numberSequence = _numberSequence.Append(_smallNumbers[1]).ToArray();
                            _positionSequence = _positionSequence.Append(1).ToArray();
                            solution = "Press the button in the second position.";
                            break; 
                        case "2":
                            _numberSequence = _numberSequence.Append(_smallNumbers[1]).ToArray();
                            _positionSequence = _positionSequence.Append(1).ToArray();
                            solution = "Press the button in the second position.";
                            break;
                        case "3":
                            _numberSequence = _numberSequence.Append(_smallNumbers[2]).ToArray();
                            _positionSequence = _positionSequence.Append(2).ToArray();
                            solution = "Press the button in the third position.";
                            break;
                        case "4":
                            _numberSequence = _numberSequence.Append(_smallNumbers[3]).ToArray();
                            _positionSequence = _positionSequence.Append(3).ToArray();
                            solution = "Press the button in the fourth position.";
                            break;
                        default:
                            break;
                    }
                    break;
                case 1:
                    switch (_display)
                    {
                        case "1":
                            _numberSequence = _numberSequence.Append(_smallNumbers[_smallNumbers.IndexOf("4")]).ToArray();
                            _positionSequence = _positionSequence.Append(_smallNumbers.IndexOf("4")).ToArray();
                            solution = "press the button labeled “4”.";
                            break;
                        case "2":
                            _numberSequence = _numberSequence.Append(_smallNumbers[1]).ToArray();
                            _positionSequence = _positionSequence.Append(1).ToArray();
                            solution = "Press the button in the second position.";
                            break;
                        case "3":
                            _numberSequence = _numberSequence.Append(_smallNumbers[0]).ToArray();
                            _positionSequence = _positionSequence.Append(0).ToArray();
                            solution = "Press the button in the first position.";
                            break;
                        case "4":
                            _numberSequence = _numberSequence.Append(_smallNumbers[3]).ToArray();
                            _positionSequence = _positionSequence.Append(3).ToArray();
                            solution = "Press the button in the fourth position.";
                            break;
                        default:
                            break;
                    }
                    break;
                case 2:
                    switch (_display)
                    {
                        case "1":
                            _numberSequence = _numberSequence.Append(_smallNumbers[_smallNumbers.IndexOf(stage2Label.ToString())]).ToArray();
                            _positionSequence = _positionSequence.Append(_smallNumbers.IndexOf(stage2Label.ToString())).ToArray();
                            solution = $"press the button labeled “{stage2Label}”.";
                            break;
                        case "2":
                            _numberSequence = _numberSequence.Append(_smallNumbers[_smallNumbers.IndexOf(stage1Label.ToString())]).ToArray();
                            _positionSequence = _positionSequence.Append(_smallNumbers.IndexOf(stage1Label.ToString())).ToArray();
                            solution = $"press the button labeled “{stage1Label}”.";
                            break;
                        case "3":
                            _numberSequence = _numberSequence.Append(_smallNumbers[2]).ToArray();
                            _positionSequence = _positionSequence.Append(2).ToArray();
                            solution = "Press the button in the third position.";
                            break;
                        case "4":
                            _numberSequence = _numberSequence.Append(_smallNumbers[3]).ToArray();
                            _positionSequence = _positionSequence.Append(3).ToArray();
                            solution = "Press the button in the fourth position.";
                            break;
                        default:
                            break;
                    }
                    break;
                case 3:
                    switch (_display)
                    {
                        case "1":
                            _numberSequence = _numberSequence.Append(_smallNumbers[_smallNumbers.IndexOf(stage1Label.ToString())]).ToArray();
                            _positionSequence = _positionSequence.Append(_smallNumbers.IndexOf(stage1Label.ToString())).ToArray();
                            solution = $"press the button labeled “{stage1Label}”.";
                            break;
                        case "2":
                            _numberSequence = _numberSequence.Append(_smallNumbers[0]).ToArray();
                            _positionSequence = _positionSequence.Append(0).ToArray();
                            solution = "Press the button in the first position.";
                            break;
                        case "3":
                            _numberSequence = _numberSequence.Append(_smallNumbers[_smallNumbers.IndexOf(stage2Label.ToString())]).ToArray();
                            _positionSequence = _positionSequence.Append(_smallNumbers.IndexOf(stage2Label.ToString())).ToArray();
                            solution = $"press the button labeled “{stage2Label}”.";
                            break;
                        case "4":
                            _numberSequence = _numberSequence.Append(_smallNumbers[_smallNumbers.IndexOf(stage2Label.ToString())]).ToArray();
                            _positionSequence = _positionSequence.Append(_smallNumbers.IndexOf(stage2Label.ToString())).ToArray();
                            solution = $"press the button labeled “{stage2Label}”.";
                            break;
                        default:
                            break;
                    }
                    break;
                case 4:
                    switch (_display)
                    {
                        case "1":
                            _numberSequence = _numberSequence.Append(_smallNumbers[_smallNumbers.IndexOf(stage1Label.ToString())]).ToArray();
                            _positionSequence = _positionSequence.Append(_smallNumbers.IndexOf(stage1Label.ToString())).ToArray();
                            solution = $"press the button labeled “{stage1Label}”.";
                            break;
                        case "2":
                            _numberSequence = _numberSequence.Append(_smallNumbers[_smallNumbers.IndexOf(stage2Label.ToString())]).ToArray();
                            _positionSequence = _positionSequence.Append(_smallNumbers.IndexOf(stage2Label.ToString())).ToArray();
                            solution = $"press the button labeled “{stage2Label}”.";
                            break;
                        case "3":
                            _numberSequence = _numberSequence.Append(_smallNumbers[_smallNumbers.IndexOf(stage4Label.ToString())]).ToArray();
                            _positionSequence = _positionSequence.Append(_smallNumbers.IndexOf(stage4Label.ToString())).ToArray();
                            solution = $"press the button labeled “{stage4Label}”.";
                            break;
                        case "4":
                            _numberSequence = _numberSequence.Append(_smallNumbers[_smallNumbers.IndexOf(stage3Label.ToString())]).ToArray();
                            _positionSequence = _positionSequence.Append(_smallNumbers.IndexOf(stage3Label.ToString())).ToArray();
                            solution = $"press the button labeled “{stage3Label}”.";
                            break;
                        default:
                            break;
                    }
                    break;
                default:
                    break;
            }
            _stage++;
            return solution;
        }
    }
}
