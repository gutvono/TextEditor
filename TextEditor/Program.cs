string path = @"C:\Dados\", file = "arquivo";

if (!Directory.Exists(path))
    Directory.CreateDirectory(path);

if (!File.Exists(path + file))
    File.Create(path + file);

StreamReader sr = new StreamReader(path + file);
Console.WriteLine(sr.ReadToEnd());
sr.Close();

Console.WriteLine();

StreamReader sr2 = new StreamReader(path + file);
//Console.WriteLine(File.ReadLines(path + file).Skip(2).Take(1).First());
Console.WriteLine(File.ReadLines(path + file).ElementAt(2));
sr2.Close();
