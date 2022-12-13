int number = ReadData("Введите число N:");
PrintData("                        ", BorderBuilder(CubesLineBuilder(number)));
PrintData("Таблица чисел от 1 до N:", NubersLineBuilder(number));
PrintData("                        ", BorderBuilder(CubesLineBuilder(number)));
PrintData("Таблица кубов от 1 до N:", CubesLineBuilder(number));
PrintData("                        ", BorderBuilder(CubesLineBuilder(number)));

//ReadData method which will print input data request message & its output is integer value inserted by the user
int ReadData(string message)
{
    //output request data message
    Console.WriteLine(message);
    //method return will be integer value received from inputed string by conversion, null safety check also is done here
    return int.Parse(Console.ReadLine() ?? "0");
}

string NubersLineBuilder(int number)
{
    string numbers = "| ";
    int i = 1;
    while(i <= number)
    {
        int space = 0;
        int j = 1;
        space = Math.Pow(i,3).ToString().Length - i.ToString().Length;
        while(j <= space)
        {
            numbers = numbers + " ";
            j++;
        }
        numbers = numbers + i + " | ";
        i++;
    }
    return numbers;
}

string CubesLineBuilder(int number)
{
    string cubes = "| ";
    int i = 1;
    while(i <= number)
    {
        cubes = cubes + Math.Pow(i, 3) + " | ";
        i++;
    }
    return cubes;
}

string BorderBuilder(string line)
{
    int length = line.Length;
    string border = string.Empty;
    int i = 1;
    while(i < length)
    {
        border = border + "-";
        i++;
    }
    return border;
}
void PrintData(string message, string line)
{
    Console.WriteLine(message + line);
}