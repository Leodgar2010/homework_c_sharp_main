// Напишите программу, которая выводит третью цифру 
// заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
Console.WriteLine ("Введите число: ");
string? numberString1 = Console.ReadLine ();
var number1=  int.Parse (numberString1!);
if (number1<0) number1 = number1*-1;
if (number1>999)
{
    while (number1 > 999)
    {
       number1 = (number1/10);
    }
}
if (number1<100)
    Console.WriteLine ("третьей цифры нет");
else
    Console.WriteLine (number1%10);
