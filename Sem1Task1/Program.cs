// read two numbers
string? Num1Line = Console.ReadLine();
string? Num2Line = Console.ReadLine();

// check if these numbers are not equal to null
if(Num1Line!=null&&Num2Line!=null)
{
    // convert strint into integer
    int num1 = int.Parse(Num1Line);
    int num2 = int.Parse(Num2Line);

    //compare num1 and num2^2
    if(num2 * num2 == num1)
    // write result of comparison
    {
        Console.WriteLine("Первое число квадрат второго.");
    }
    else
    {
        Console.WriteLine("Первое число не является квадратом второго.");
    }
}