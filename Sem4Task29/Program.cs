string line = ReadLine("Введите перечень имен, разделяя их запятой:");
PrintResult("Случайное имя из данного перечня: ", RandomName(line));

string ReadLine(string message)
{
    Console.WriteLine(message);
    return Console.ReadLine() ?? "0";
}

string RandomName(string line)
{
    string[] names = line.Split(',');
    int lenght = names.Length;
    Random rnd = new Random();
    int randnum = rnd.Next(0, lenght+1);
    string randname = names[randnum];
    return randname;
}

void PrintResult(string message, string randname)
{
    Console.WriteLine(message + randname);
}