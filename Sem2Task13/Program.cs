Console.WriteLine("Введите число:");
// read number string & convert to integer & null safety check
int numberN = int.Parse(Console.ReadLine()??"0");
//create variable to store result
char[] digits = numberN.ToString().ToCharArray();
int numberLegth = digits.Length;
if(numberLegth>2)
{
    Console.WriteLine("Третья цифра в данном числе: " + digits[2]);
}
else
{
    Console.WriteLine("В данном числе нет третьей цифры!");
}