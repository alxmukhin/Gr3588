Console.WriteLine("Введите число:");
// read number string & convert to integer & null safety check
int numberN = int.Parse(Console.ReadLine()??"0");
//convert integer into string and then to arrray
char[] digits = numberN.ToString().ToCharArray();
//define number of elements in array
int numberLegth = digits.Length;
//check if number consists of 3 digits and more
if(numberLegth>2)
{
    //output result, thirds digit is stored as second element of array as their count starts from 0
    Console.WriteLine("Третья цифра в данном числе: " + digits[2]);
}
else
{
    //output message saying that number does not have third digit
    Console.WriteLine("В данном числе нет третьей цифры!");
}