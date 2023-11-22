using ktane;

Bomb bomb = new();

// 6 lång
bomb.SetSerial("Alpha beta five zeta delta 5");

// ex: "3 small two big"
bomb.SetBatteries("two big 3 small");

// "DVI" "PARALLEL" "PS2" "RJ45" "SERIAL" "STEREO"
bomb.AddPort("dvi serial");

//just an int
bomb.SetPortPlates("2");

// "SND" "CLR" "CAR" "IND" "FRQ" "SIG" "NSA" "MSA" "TRN" "BOB" "RFK"
bomb.AddIndicator("beta omega beta lit ");
bomb.AddIndicator("Sierra november delta");



SimonSays module = new(bomb);


Console.WriteLine(module.AppendToSequence("red"));
Console.WriteLine(module.AppendToSequence("green"));
Console.WriteLine(module.AppendToSequence("red"));
Console.WriteLine(module.AppendToSequence("blue"));
