//use method PrintData to collect number N from user
int number = ReadData("Введите число N:");
//use PrintData method to create output table by drawing horizontal lines using BorderBuilder method and representing lines with numbers and their cubes
PrintData("                        ", BorderBuilder(CubesLineBuilder(number)));
PrintData("Таблица чисел от 1 до N:", NubersLineBuilder(number));
PrintData("                        ", BorderBuilder(CubesLineBuilder(number)));
PrintData("Таблица кубов от 1 до N:", CubesLineBuilder(number));
PrintData("                        ", BorderBuilder(CubesLineBuilder(number)));

//ReadData method prints input data request message and cololects it; its output is integer value inserted by the user
int ReadData(string message)
{
    //output request data message
    Console.WriteLine(message);
    //method return will be integer value received from inputed string by conversion, null safety check also is done here
    return int.Parse(Console.ReadLine() ?? "0");
}

//method NumbersLineBuilder creates string with numbers from 1 to N
string NubersLineBuilder(int number)
{
    //string starts with table vertical border
    string numbers = "| ";
    int i = 1;
    //calculate spaces and build numbers line
    while(i <= number)
    {
        //create variable to store number of spaces before number in order to align it with cube
        int space = 0;
        int j = 1;
        //calculate space as difference of symbols quantity in cube and number
        space = Math.Pow(i,3).ToString().Length - i.ToString().Length;
        //add spaces before number for alignment
        while(j <= space)
        {
            numbers = numbers + " ";
            j++;
        }
        //build string with numbers, use dash as table inner vertical border
        numbers = numbers + i + " | ";
        i++;
    }
    //method return is string of numbers from 1 to N
    return numbers;
}

//method CubesLineBuilder creates string containing cubes of numbers from 1 to N
string CubesLineBuilder(int number)
{
    //string starts with table vertical border
    string cubes = "| ";
    int i = 1;
    //build cubes of numbers from 1 to N line
    while(i <= number)
    {
        //build string with cubes of numbers, use dash as table inner vertical border
        cubes = cubes + Math.Pow(i, 3) + " | ";
        i++;
    }
    //method return is string of cubes for numbers from 1 to N
    return cubes;
}

//method BorderBuilder draws horizontal lines of the table, lenght of border is equal to string line
string BorderBuilder(string line)
{
    //define string lenghth
    int length = line.Length;
    //create new string to draw border
    string border = string.Empty;
    int i = 1;
    //create new string which will contain number of dashes equal to string length
    while(i < length)
    {
        //string drawing by adding dashes
        border = border + "-";
        i++;
    }
    //method return will be string of dashes which will be used as table border
    return border;
}

//PrintData method outputs results
void PrintData(string message, string line)
{
    //output contains of two strings
    Console.WriteLine(message + line);
}