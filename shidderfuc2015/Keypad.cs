namespace ktane
{
    public class Keypad
    {
        private string[] row1 = { "BALLOON", "AT", "LAMBDA", "SQUIGGLYN", "SQUIDKNIFE", "HOOKN", "LEFTC"};
        private string[] row2 = { "EURO", "BALLOON", "LEFTC", "CURSIVE", "HOLLOWSTAR", "HOOKN", "QUESTIONMARK"};
        private string[] row3 = { "COPYRIGHT", "PUMPKIN", "CURSIVE", "DOUBLEK", "MELTEDTHREE", "LAMBDA", "HOLLOWSTAR"};
        private string[] row4 = { "SIX", "PARAGRAPH", "BT", "SQUIDKNIFE", "DOUBLEK", "QUESTIONMARK", "SMILEYFACE"};
        private string[] row5 = { "PITCHFORK", "SMILEYFACE", "BT", "LEFTC", "PARAGRAPH", "DRAGON", "FILLEDSTAR"};
        private string[] row6 = { "SIX", "EURO", "TRACKS", "AE", "PITCHFORK", "NWITHHAT", "OMEGA"};

        private readonly string[] validKeys = { "BALLOON", "AT", "LAMBDA", "SQUIGGLYN", 
            "SQUIDKNIFE", "HOOKN", "LEFTC", "EURO", "CURSIVE", "HOLLOWSTAR", "QUESTIONMARK", 
            "COPYRIGHT", "PUMPKIN", "DOUBLEK", "MELTEDTHREE", "SIX", "PARAGRAPH", "BT", 
            "SMILEYFACE", "PITCHFORK", "DRAGON", "FILLEDSTAR", "TRACKS", "AE", "NWITHHAT", "OMEGA"};
        
        private string[] registeredKeys = Array.Empty<string>();

        private void InterpretString(string input)
        {

        }
        private void RegisterKey(string input)
        {
            if (registeredKeys.Length >= 4) 
            {
                return;
            }




        }
    }
}
