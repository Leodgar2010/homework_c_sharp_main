// Напишите программу, которая принимает 
// на вход трёхзначное число и на 
// выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1
Console.WriteLine ("Введите трёхзначное число: ");
string? numberString1 = Console.ReadLine ();
var number1=  int.Parse (numberString1!);
if (number1<0) number1 = number1*-1;
if (number1>999 || number1<100)
{
     Console.WriteLine ("введенное число не трехзначное");
}
else
{   
    number1 = (number1 % 100)/10;
    Console.WriteLine ("Вторая цифра этого числа: "+number1);
}