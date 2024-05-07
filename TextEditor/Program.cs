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


//if (File.Exists(path + file))
//{
//}

//StreamWriter sw = new(path + file);

//Console.WriteLine("Informe seu nome:");
//sw.WriteLine(Console.ReadLine());

//Console.WriteLine("Informe seu email:");
//sw.WriteLine(Console.ReadLine());
//sw.Close();

//StreamReader sr = new (path + file);

//Console.Clear();
//Console.WriteLine(sr.ReadToEnd());
//sr.Close();