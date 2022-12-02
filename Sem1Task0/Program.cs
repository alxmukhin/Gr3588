// read two numbers
string? Num1Line = Console.ReadLine();
string? Num2Line = Console.ReadLine();

// check if these numbers are not equal to null
if(Num1Line!=null&&Num2Line!=null)
{
    // convert strint into integer
    int num1 = int.Parse(Num1Line);
    int num2 = int.Parse(Num2Line);

    //multiply two numbers
    int outResult = num1*num2;

    //write result
    Console.WriteLine(outResult);
}