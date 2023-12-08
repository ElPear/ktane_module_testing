namespace ktane
{
    public class TheButton
    {
        public TheButton(Bomb bomb) 
        {
            bombPeriph = bomb;
        }
        private Bomb bombPeriph;
        private string _buttonText = "";
        private readonly string[] _validText = { "HOLD", "PRESS", "DETONATE", "ABORT" };
        private string _buttonColor = "";
        private readonly string[] _validButtonColor = { "BLUE", "RED", "WHITE", "YELLOW" };
        private readonly string[] _validStripColor = { "BLUE", "WHITE", "YELLOW" };
        private string _stripColor = "";

        public void SetButtonText(string input)
        {
            string[] inputs = input.Split(" ");
            foreach (string item in inputs)
            {
                if (_validText.Contains(item)) 
                {
                _buttonText = item;
                    return;
                }
            }
        }
        public void SetButtonColor(string input)
        {
            string[] inputs = input.Split(" ");
            foreach (string item in inputs)
            {
                if (_validButtonColor.Contains(item))
                {
                    _buttonColor = item;
                    return;
                }
            }
        }
        public void SetStripColor(string input)
        {
            string[] inputs = input.Split(" ");
            foreach (string item in inputs)
            {
                if (_validStripColor.Contains(item))
                {
                    _stripColor = item;
                    return;
                }
            }
        }
        public string SolveModule()
        {
            switch (_buttonColor)
            {
                case "BLUE":
                    if (_buttonText == "ABORT")
                    {
                        _buttonColor = string.Empty;
                        return "Hold button and register color of the strip";
                    }
                    break;

                case "RED":
                    if (_buttonText == "HOLD")
                    {
                        return "tap the button";
                    }
                    break;

                case "WHITE":
                    if (bombPeriph.Indicators.Contains("1CAR"))
                    {
                        _buttonColor = string.Empty;
                        return "Hold button and register color of the strip";
                    }
                    break;
                
                case "YELLOW":
                    _buttonColor = string.Empty;
                    return "Hold button and register color of the strip";
                
                default:
                    if (bombPeriph.TotalBatteries > 1 && _buttonColor == "RED")
                    {
                        return "tap the button";
                    }
                    if (bombPeriph.TotalBatteries > 2 && bombPeriph.Indicators.Contains("1FRK"))
                    {
                        return "tap the button";
                    }
                    if (_stripColor == string.Empty)
                    {
                        return "Hold button and register color of the strip";
                    }
                    else
                    {
                        switch (_stripColor)
                        {
                            case "BLUE":
                                return "Release the button when the timer has a 4 in any position";
                            case "WHITE":
                                return "Release the button when the timer has a 1 in any position";
                            case "YELLOW":
                                return "Release the button when the timer has a 5 in any position";
                            default:
                                break;
                        }
                    }
                break;
            }
            return "Error, check your input fucktard";
        }
    }
}
