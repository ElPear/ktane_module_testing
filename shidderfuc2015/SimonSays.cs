using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ktane
{
    public class SimonSays
    {
        public SimonSays(Bomb bomb) { bombPeriphs = bomb; }
        private Bomb bombPeriphs;
        private string[] _playerSequence = Array.Empty<string>();
        private readonly string[] _validColors = { "RED", "BLUE", "GREEN", "YELLOW" };
        private string[] _vowels = { "A","E","I","O","U","Y" };

        public string AppendToSequence(string input)
        {
            string[] split = input.ToUpper().Split(" ");
            
            foreach (string item in split) 
            {
                if (_validColors.Contains(item))
                {
                    _playerSequence = _playerSequence.Append(item).ToArray();
                    break;
                }
            }
            return GetSolution();
        }
        public string GetSolution()
        {
         string[] _internalSequence = Array.Empty<string>();

        bool vowel = false;
            foreach (string item in _vowels)
            {
                if (bombPeriphs.Serial.Contains(item)) { vowel = true; }
            }


            foreach (string item in _playerSequence)
            {
                if (vowel)
                {
                    switch (bombPeriphs.Strikes)
                    {
                        case 0:
                            switch (item)
                            {
                                case "RED":
                                    _internalSequence = _internalSequence.Append("BLUE").ToArray();
                                    break;
                                case "BLUE":
                                    _internalSequence = _internalSequence.Append("RED").ToArray();
                                    break;
                                case "GREEN":
                                    _internalSequence = _internalSequence.Append("YELLOW").ToArray();
                                    break;
                                case "YELLOW":
                                    _internalSequence = _internalSequence.Append("GREEN").ToArray();
                                    break;
                                default:
                                    break;
                            }
                            break;

                        case 1:
                            switch (item)
                            {
                                case "RED":
                                    _internalSequence = _internalSequence.Append("YELLOW").ToArray();
                                    break;
                                case "BLUE":
                                    _internalSequence = _internalSequence.Append("GREEN").ToArray();
                                    break;
                                case "GREEN":
                                    _internalSequence = _internalSequence.Append("BLUE").ToArray();
                                    break;
                                case "YELLOW":
                                    _internalSequence = _internalSequence.Append("RED").ToArray();
                                    break;
                                default:
                                    break;
                            }
                            break;

                        default:
                            switch (item)
                            {
                                case "RED":
                                    _internalSequence = _internalSequence.Append("GREEN").ToArray();
                                    break;
                                case "BLUE":
                                    _internalSequence = _internalSequence.Append("RED").ToArray();
                                    break;
                                case "GREEN":
                                    _internalSequence = _internalSequence.Append("YELLOW").ToArray();
                                    break;
                                case "YELLOW":
                                    _internalSequence = _internalSequence.Append("BLUE").ToArray();
                                    break;
                                default:
                                    break;
                            }
                            break;
                    }
                }
                else
                {
                    switch (bombPeriphs.Strikes)
                    {
                        case 0:
                            switch (item)
                            {
                                case "RED":
                                    _internalSequence = _internalSequence.Append("BLUE").ToArray();
                                    break;
                                case "BLUE":
                                    _internalSequence = _internalSequence.Append("YELLOW").ToArray();
                                    break;
                                case "GREEN":
                                    _internalSequence = _internalSequence.Append("GREEN").ToArray();
                                    break;
                                case "YELLOW":
                                    _internalSequence = _internalSequence.Append("RED").ToArray();
                                    break;
                                default:
                                    break;
                            }
                            break;

                        case 1:
                            switch (item)
                            {
                                case "RED":
                                    _internalSequence = _internalSequence.Append("RED").ToArray();
                                    break;
                                case "BLUE":
                                    _internalSequence = _internalSequence.Append("BLUE").ToArray();
                                    break;
                                case "GREEN":
                                    _internalSequence = _internalSequence.Append("YELLOW").ToArray();
                                    break;
                                case "YELLOW":
                                    _internalSequence = _internalSequence.Append("GREEN").ToArray();
                                    break;
                                default:
                                    break;
                            }
                            break;

                        default:
                            switch (item)
                            {
                                case "RED":
                                    _internalSequence = _internalSequence.Append("YELLOW").ToArray();
                                    break;
                                case "BLUE":
                                    _internalSequence = _internalSequence.Append("GREEN").ToArray();
                                    break;
                                case "GREEN":
                                    _internalSequence = _internalSequence.Append("BLUE").ToArray();
                                    break;
                                case "YELLOW":
                                    _internalSequence = _internalSequence.Append("RED").ToArray();
                                    break;
                                default:
                                    break;
                            }
                            break;
                    }
                }
            }

            string solution = "";
            foreach(string item in _internalSequence)
                solution += item+" ";
            
                
                
                return solution;
            
        }
    }
}
