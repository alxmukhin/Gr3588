
int NumberA = ReadNumber("Введите число A:");
int numberB = ReadNumber("Введите число B:");
string oprtr = ReadOperator("Введите оператор (доступные операции: A+B - сложение, A-B - вычитание, А*В - умножение, А/В - деление; А^В - возведение в степень):");
PrintResult("Результат вычисления: ", Operations(NumberA, numberB, oprtr));

int ReadNumber(string message)
{
    Console.WriteLine(message);
    return int.Parse(Console.ReadLine() ?? "0");
}

string ReadOperator(string message)
{
    Console.WriteLine(message);
    return Console.ReadLine() ?? "0";
}

double Operations(int number1, int number2, string oprtr)
{
    double result = 0;
    int oprtrnumber = 0;
    if(oprtr == "+") oprtrnumber = 1;
    if(oprtr == "-") oprtrnumber = 2;
    if(oprtr == "*") oprtrnumber = 3;
    if(oprtr == "/") oprtrnumber = 4;
    if(oprtr == "^") oprtrnumber = 5;
    switch(oprtrnumber)
    {
        case 1: result = number1 + number2; break;
        case 2: result = number1 - number2; break;
        case 3: result = number1 * number2; break;
        case 4: result = number1 / number2; break;
        case 5: result = Math.Pow(number1, number2); break;
        default: Console.WriteLine("Введенный оператор не предусмотрен программой!"); break;
    }
    return result;
}

void PrintResult(string message, double result)
{
    if(result != 0)
    {
        Console.WriteLine(message + result);
    }
    else
    {
        return;
    }
}