// Напишите программу, которая принимает 
// на вход пятизначное число и проверяет, 
// является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
Console.WriteLine("Проверка является ли данное пятизначное число палиндромом.");
Console.WriteLine("Введите пятизначное число:");
var numberString = Console.ReadLine();
int number = int.Parse(numberString!);
if (number<0) number = number*-1;
if (number>99999 || number<10000)
{
     Console.WriteLine ("Данное число не пятизначное.");
     return;
}
int last_two_numbers = (number%100);
int first_two_numbers= (number/1000);
if ((last_two_numbers/10) == (first_two_numbers%10) && (last_two_numbers%10) == (first_two_numbers/10)) 
Console.WriteLine ("Данное число является палиндромом.");
else 
Console.WriteLine ("Данное число не является палиндромом."); 


