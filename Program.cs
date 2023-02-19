var planet = new basic_c_sharp.Planet(1);
planet.Name = "Pluto";
planet.Radius = 10000;
planet.PrintInfo();
Console.WriteLine();
Console.WriteLine($"Temprature: {planet.GetTempratureId()}");
Console.WriteLine();
planet.AddSatelite("Bulan");