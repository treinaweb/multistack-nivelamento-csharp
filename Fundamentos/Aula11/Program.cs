var medias = new Dictionary<string, double>();
medias.Add("Elton", 10.0);
medias.Add("Cleyson", 9.5);
medias.Add("Amauri", 7.2);

Console.WriteLine(medias["Elton"]);
Console.WriteLine(medias["Cleyson"]);
Console.WriteLine(medias["Amauri"]);

medias["Cleyson"] = 10.0;
Console.WriteLine(medias["Cleyson"]);

medias["Ana"] = 9.1;
Console.WriteLine(medias["Ana"]);

medias.Remove("Cleyson1");
Console.WriteLine(medias["Cleyson"]);