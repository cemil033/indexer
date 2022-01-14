using System;
using indexer;
using World;

Dictionary dictionary=new();
dictionary.Addword(new() { key = "mucerret", value = "abstract" });
dictionary.Addword(new() { key = "miras", value = "inhertance" });
dictionary.Addword(new() { key = "kapsullasma", value = "encapsulation" });

//Console.WriteLine(dictionary["miras"]);

City Baki = new() { Ehalisayi = 1000000 };
City Ankara = new() { Ehalisayi = 5663322 };
City London = new() { Ehalisayi = 8908081 };

Console.WriteLine((Baki!=London));