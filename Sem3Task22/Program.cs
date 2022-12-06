int numberN = ReadData("Введите число N: ");
string outline1 = LineBuilder(numberN, 1);
PrintResult("Числа от 1 до N: ", outline1);
string outline2 = LineBuilder(numberN, 2);
PrintResult("Квадраты чисел от 1 до N: ", outline2);

int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

string LineBuilder(int num, int pow)
{
    string line = string.Empty;
    for (int i=1; i<num; i++)
    {
        line = line + " " + Math.Pow(i, pow);
    }
    line = line + " " + Math.Pow(num, pow);
    return line;
}

void PrintResult(string msg, string line)
{
    Console.WriteLine(msg + line);
}