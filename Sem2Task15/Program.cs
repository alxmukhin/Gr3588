Console.WriteLine("Введите число:");
// read number string & convert to integer & null safety check
int dayNumber = int.Parse(Console.ReadLine()??"0");
//create array with days of week
string[] dayWeek = {"понедельник","вторник","среда","четверг","пятница","суббота","воскресенье"};
//check if input value corresponds days of weer range 1 to 7
if(dayNumber>0 && dayNumber<8)
{
    //check if day number is greater than 6, as weekend includes 6 and 7 days
    if(dayNumber>5)
    {
        //output result that day number is related to weekend
        Console.WriteLine("День недели "+ dayNumber + " - " + dayWeek[dayNumber-1] + " является выходным днем.");
    }
    else
    {
        //output result that day number is not related to weekend
        Console.WriteLine("День недели "+ dayNumber + " - " + dayWeek[dayNumber-1] + " не является выходным днем.");
    }
}
else
{
    //output result inserted number does not represent day of week
    Console.WriteLine("Введено неправильное значение, номера дней недели лежат в диапазоне от 1 до 7!");
}