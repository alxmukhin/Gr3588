string? inputLine = Console.ReadLine();

if (inputLine!=null)
{
    int inputNumber = int.Parse(inputLine);
    int outDigit = inputNumber % 10;
    Console.WriteLine(outDigit);
}