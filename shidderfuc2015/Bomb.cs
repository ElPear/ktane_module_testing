using System;
namespace ktane
{
    public class Bomb
    {
        private string _serial = "Unset";
        private int _totalBatteries;
        private int _smallBatteries;
        private int _bigBatteries;
        private string[] _ports = Array.Empty<string>();
        private int _portPlates;
        private string[] _indicators = Array.Empty<string>();
        private int _strikes = 0;

        public string Serial { get { return _serial; } }
        public int SmallBatteries { get { return _smallBatteries; } }
        public int BigBatteries { get { return _bigBatteries; } }
        public int TotalBatteries { get { return _totalBatteries; } }
        public string[] Ports { get { return _ports; } }
        public int PortPlates { get { return _portPlates; } }
        public string[] Indicators { get { return _indicators; } }
        public int Strikes { get { return _strikes; } }


        private static string CleanString(string input)
        {
            string[] stringNumbers = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            for (int i = 0; i < stringNumbers.Length; i++)
            {
                try
                {
                    input = input.Replace(stringNumbers[i], i.ToString());
                }
                catch { }
            }

            return input;
        }
        public void SetSerial(string input)
        {
            input = CleanString(input);
            string serial = "";
            string[] inputArray = input.ToUpper().Split(' ');

            foreach (var item in inputArray)
            {
                serial += item[0];
            }
            if (serial.Length == 6)
            {
                _serial = serial;
            }
            else { }

        }
        public void ResetSerial() 
        {
            _serial = string.Empty;
        }
        public void SetBatteries(string input)
        {
            // ex: two small one big
            // or one big two small

            input = CleanString(input);

            string[] inputArray = input.Split(" ");
            for (int i = 1; i < inputArray.Length; i++)
            {
                int num;
                if (int.TryParse(inputArray[i-1],out num))
                {
                    switch (inputArray[i])
                    {
                        case "small":
                            _smallBatteries = num;
                            break;
                        case "big":
                            _bigBatteries = num;
                            break;
                           
                        default:
                            break;
                    }
                }
            }
            try
            {
                _totalBatteries = _bigBatteries + _smallBatteries;
            }
            catch
            {
            }
        }
        public void ResetBatteries()
        {
            _smallBatteries = 0;
            _bigBatteries = 0;
            _totalBatteries = 0;
        }
        public void AddPort(string input)
        {
            string[] valid = { "DVI", "PARALLEL", "PS2", "RJ45", "SERIAL", "STEREO" };
            input = CleanString(input).ToUpper();
            foreach (string item in input.Split(" "))
            {
                if (valid.Contains(item))
                {
                    _ports = _ports.Append(item).ToArray();
                }
            }
        }
        public void SetPortPlates(string input) 
        {
            input = CleanString(input);
            int.TryParse(input, out _portPlates);
        }
        public void ResetPort() 
        {
            _ports = Array.Empty<string>();
        }
        public void AddIndicator(string input)
        {
            input = CleanString(input).ToUpper();
            bool state = input.Contains("LIT");
            input = input.Replace("LIT", "");
            

            string text = "";
            string[] valid = {"SND", "CLR", "CAR", "IND", "FRQ", "SIG", "NSA", "MSA", "TRN", "BOB", "RFK"};

            foreach (string item in input.Trim().Split(" "))
            {
                text += item[0];
            }
            if (valid.Contains(text)) 
            {
                if (state)
                    _indicators = _indicators.Append($"1{text}").ToArray();
                else
                    _indicators = _indicators.Append($"0{text}").ToArray();
            }
        }
        public void ResetIndicator() 
        {
            _indicators = Array.Empty<string>();
        }
        public void IncrementStrikes()
        {
            _strikes++;
        }
        public void ResetStrikes()
        {
            _strikes = 0;
        }


    }
}