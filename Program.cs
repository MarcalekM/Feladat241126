using Feladat241126;

Auto auto = new("AVH-139", "Ford", "Mustang", 6015, 260, 4.5f, "Víz Elek", "Para Zita", "Zsíros B. Ödön");
Auto auto02 = new("RGB-025");

//string[] nevek = ["Víz Elek", "Para Zita", "Zsíros B. Ödön"];
//auto.UjTulajdonosokListábaVétele("Víz Elek", "Para Zita", "Zsíros B. Ödön");

Console.WriteLine(auto.ToString() + "\n");
Console.WriteLine(auto.TulajdonosokLekérdezése());